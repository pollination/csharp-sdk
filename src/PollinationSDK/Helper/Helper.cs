﻿using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;
using PollinationSDK.Wrapper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using QueenbeeSDK;

namespace PollinationSDK
{
    public static class Helper
    {
        public static UserPrivate CurrentUser { get; set; }

        public static UserPrivate GetUser()
        {
            var api = new UserApi();
            //var config = api.Configuration;
            var me = api.GetMe();
            return me;
        }

        /// <summary>
        /// Get a project by current user and name. If not found, then create a new project.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public static Project GetAProject(string userName, string projectName)
        {
            var api = new ProjectsApi();
            try
            {
                var d = api.GetProject(userName, projectName);
                return d;
            } 
            catch (ApiException e)
            {
                // Project not found and person account, create a default demo project.
                if (e.ErrorCode == 404 && userName == Helper.CurrentUser.Username)
                {
                    var ifPublic = projectName == "demo";
                    var res = api.CreateProject(userName, new ProjectCreate(projectName, _public: ifPublic));
                    return GetAProject(userName, projectName);
                }
                throw e;
            }
           
            
            //var d = GetProjects(user).FirstOrDefault(_ => _.Name == projectName);
            //return d;
        }

        public static async Task<bool> UploadDirectoryAsync(Project project, string directory, Action<int> reportProgressAction = default, CancellationToken cancellationToken = default)
        {

            var files = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);
            var tasks = files.Select(_ => UploadArtifaceAsync(project, _, _.Replace(directory, ""))).ToList();
            var total = files.Count();


            var finishedPercent = 0;
            reportProgressAction?.Invoke(finishedPercent);
            while (tasks.Count() > 0)
            {
                // canceled by user
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Canceled uploading by user");
                    break;
                }

                var finishedTask = await Task.WhenAny(tasks);

                tasks.Remove(finishedTask);

                var unfinishedUploadTasksCount = tasks.Count();
                finishedPercent = (int)((total - unfinishedUploadTasksCount) / (double)total * 100);
                reportProgressAction?.Invoke(finishedPercent);

            }

            // canceled by user
            if (cancellationToken.IsCancellationRequested) return false;

            Console.WriteLine("Finished uploading directory");
            return true;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullPath">something like: "C:\Users\mingo\Downloads\Compressed\project_folder\project_folder\model\grid\room.pts"</param>
        /// <param name="relativePath">"model\grid\room.pts"</param>
        public static async Task<bool> UploadArtifaceAsync(Project project, string fullPath, string relativePath)
        {
            var filePath = fullPath;
            var fileRelativePath = relativePath.Replace('\\', '/');
            if (fileRelativePath.StartsWith("/")) 
                fileRelativePath = fileRelativePath.Substring(1);

            //fileRelativePath = "project_folder/" + fileRelativePath;
            var api = new ArtifactsApi();
            var artf = await api.CreateArtifactAsync(project.Owner.Name, project.Name, new KeyRequest(fileRelativePath));

            var url = artf.Url;


            //Use RestSharp
            RestClient restClient = new RestClient(url);
            RestRequest restRequest = new RestRequest();
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.POST;
            restRequest.AddHeader("Content-Type", "multipart/form-data");
            restRequest.AddParameter("AWSAccessKeyId", artf.Fields["AWSAccessKeyId"]);
            restRequest.AddParameter("policy", artf.Fields["policy"]);
            restRequest.AddParameter("signature", artf.Fields["signature"]);
            restRequest.AddParameter("key", artf.Fields["key"]);
            restRequest.AddFile("file", filePath);
            var response = restClient.Execute(restRequest);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                Console.WriteLine($"Done uploading: {fileRelativePath}");
                return true;
            }
            return false;


        }

      
       
       

        public static bool GetRecipeFromRecipeSourceURL(string recipeSource, out string recipeOwner, out string recipeName, out string recipeVersion)
        {
            recipeOwner = null;
            recipeName = null;
            recipeVersion = null;

            //https://api.staging.pollination.cloud/registries/ladybug-tools/recipe/annual-daylight/0.2.0

            //var recipeSource = job.Source;
            if (string.IsNullOrEmpty(recipeSource)) return false;
            if (!recipeSource.Contains("pollination.cloud/registries/")) return false;
            var items = recipeSource.Split(new[] { "pollination.cloud/registries/" }, StringSplitOptions.RemoveEmptyEntries);
            items = items[1].Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (items.Count() != 4) return false;
            recipeOwner = items[0];
            recipeName = items[2];
            recipeVersion = items[3];
            return true;
        }

      

        
    
        private static async Task<List<string>> Download(string url, string dir)
        {

            try
            {
                // downloaded folder
                var task = DownloadFromUrlAsync(url, dir);
                var finishedTask = await Task.WhenAny(new[] { task });
                var downloadedFileFolder = finishedTask.Result;

                var filePaths = new List<string>();
                if (Directory.Exists(downloadedFileFolder))
                {
                    var items = Directory.EnumerateFileSystemEntries(downloadedFileFolder, "*", SearchOption.TopDirectoryOnly);
                    filePaths = items.Any() ? items.ToList() : filePaths;
                }
                else
                {
                    filePaths.Add(downloadedFileFolder);
                }
                return filePaths;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<List<string>> DownloadArtifactZip(RunInfo runInfo, string zipFileName, string saveAsDir = default, Action<int> reportProgressAction = default)
        {
            try
            {
                var simuApi = new PollinationSDK.Api.RunsApi();

                var url = simuApi.DownloadRunArtifact(runInfo.Project.Owner.Name, runInfo.Project.Name, runInfo.RunID, zipFileName).ToString();

                var dir = string.IsNullOrEmpty(saveAsDir) ? GenTempFolder() : saveAsDir;
                var simuID = runInfo.RunID.Substring(0, 8);
                dir = Path.Combine(dir, simuID);
                // downloaded folder
                return await Download(url, dir);
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        public static async Task<List<string>> DownloadSimulationInputAssets(RunInfo runInfo, string saveAsDir = default, Action<int> reportProgressAction = default)
        {
            try
            {
                var simuApi = new PollinationSDK.Api.RunsApi();
                //var url = simuApi.GetSimulationInputs(runInfo.Project.Owner.Name, runInfo.Project.Name, runInfo.RunID).ToString();
                var url = "";

                var dir = string.IsNullOrEmpty(saveAsDir) ? GenTempFolder() : saveAsDir;
                var simuID = runInfo.RunID.Substring(0, 8);
                dir = Path.Combine(dir, simuID, "inputs");
                // downloaded folder
                return await Download(url, dir);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static async Task<string> DownloadFromUrlAsync(string url, string saveAsDir)
        {
            var file = string.Empty;
            var outputDirOrFile = string.Empty;

            Console.WriteLine($"Simulation output link url: {url}");
            var request = new RestRequest(Method.GET);
            var client = new RestClient(url.ToString());
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Unable to download file");

            // prep file path
            var fileName = Path.GetFileName(url).Split(new[] { '?' })[0];

            Directory.CreateDirectory(saveAsDir);
            file = Path.Combine(saveAsDir, fileName);

            var b = response.RawBytes;
            File.WriteAllBytes(file, b);

            if (!File.Exists(file)) throw new ArgumentException($"Failed to download {fileName}");
            outputDirOrFile = file;

            // unzip
            try
            {
                if (file.ToLower().EndsWith(".zip")) outputDirOrFile = Helper.Unzip(file, saveAsDir, true);
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Failed to unzip file {Path.GetFileName(file)}.\n -{e.Message}");
            }

            Console.WriteLine($"Finished downloading: {url} to {outputDirOrFile}");
            return outputDirOrFile;

        }
        
        /// <summary>
        /// Download an artifact(file/folder) items independently.
        /// </summary>
        /// <param name="simu"></param>
        /// <param name="artifact"></param>
        /// <param name="saveAsDir"></param>
        /// <returns></returns>
        public static List<Task<string>> DownloadArtifactWithItems(RunInfo simu, QueenbeeSDK.DAGPathOutput artifact, string saveAsDir)
        {
            var file = string.Empty;
            var outputDirOrFile = string.Empty;
            try
            {
                var api = new PollinationSDK.Api.RunsApi();
                var files = api.ListRunArtifacts(simu.Project.Owner.Name, simu.Project.Name, simu.RunID, page: 1, perPage: 100);
                var found = files.FirstOrDefault(_ => _.FileName == artifact.Name);
                if (found == null) throw new ArgumentException($"{artifact.Name} doesn't exist in {simu.Project.Owner.Name}/{simu.Project.Name}/{simu.RunID}");

                var dir = string.IsNullOrEmpty(saveAsDir) ? GenTempFolder() : saveAsDir;
                var simuID = simu.RunID.Substring(0, 8);

                var tasks = new List<Task<string>>();
                dir = Path.Combine(dir, simuID);
                ListFilesFromFolder(ref tasks, dir, simu.Project.Owner.Name, simu.Project.Name, simu.RunID, found, api);

                return tasks;

               

            }
            catch (Exception e)
            {
                throw new ArgumentException($"Failed to download artifact {artifact.Name}.\n -{e.Message}");
            }

            // loop through files in folder
            void ListFilesFromFolder(ref List<Task<string>> ts, string saveDir, string owner, string projName, string simuID,  FileMeta artfact, RunsApi RunsApi )
            {
                var dir = saveDir;
                var api = RunsApi;
                if (artfact.Type == "file")
                {
                    var url = api.DownloadRunArtifact(owner, projName, simuID, artfact.Key).ToString();
                    var task = DownloadFromUrlAsync(url, dir);
                    ts.Add(task);
                }
                else if (artfact.Type == "folder")
                {
                    dir = Path.Combine(dir, artfact.FileName);
                    var files = api.ListRunArtifacts(owner, projName, simuID, page: 1, perPage: 100, path: new[] { artifact.Name }.ToList());
                    foreach (var item in files)
                    {
                        // get all files in folder
                        if (item.Type == "folder")
                        {
                            ListFilesFromFolder(ref ts, dir, owner, projName, simuID, item, api);
                            continue;
                        }
                        // item is file
                        var url = api.DownloadRunArtifact(owner, projName, simuID, item.Key).ToString();
                        var task = DownloadFromUrlAsync(url, dir);

                        ts.Add(task);
                    }
                }
            }

        }

        /// <summary>
        /// Return the Pollination directory saved in Temp folder
        /// </summary>
        /// <returns></returns>
        public static string GenTempFolder()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), "Pollination");
            Directory.CreateDirectory(tempDir);
            return tempDir;
        }

        internal static string Unzip(string zipFilePath, string saveAsDir, bool removeZip)
        {
            if (!File.Exists(zipFilePath)) throw new ArgumentException($"{Path.GetFileName(zipFilePath)} does not exist!");
            var tempDir = new DirectoryInfo(Path.Combine(GenTempFolder(), Path.GetRandomFileName()));
            // Directory.CreateDirectory(tempDir.FullName);
            ZipFile.ExtractToDirectory(zipFilePath, tempDir.FullName);


            //copy folder
            try
            {
                if (removeZip)
                    File.Delete(zipFilePath);
                CopyDirectory(tempDir.FullName, saveAsDir);
                
            }
            catch (Exception e)
            {
                throw new ArgumentException($"Failed to save files to: {saveAsDir}.\n -{e.Message}");
            }

            var outputDirOrFile = saveAsDir;


            var subItems = tempDir.GetFileSystemInfos("*", SearchOption.TopDirectoryOnly);

            if (subItems.Count() == 1 )
            {
                // if there is only one file/folder inside
                var f = subItems[0];
                if (f.Exists) outputDirOrFile = Path.Combine(saveAsDir, f.Name);
            }

            return outputDirOrFile;
        }

        //https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories?redirectedfrom=MSDN
        private static void CopyDirectory(string sDir, string dDir)
        {
            if (!Directory.Exists(sDir)) return;
            var dir = new DirectoryInfo(sDir);

            if (!Directory.Exists(dDir)) Directory.CreateDirectory(dDir);

            // copy files
            var files = dir.GetFiles();
            foreach (var f in files)
            {
                string t = Path.Combine(dDir, f.Name);
                f.CopyTo(t, true);
            }

            // copy dirs
            var dirs = dir.GetDirectories();
            foreach (var subdir in dirs)
            {
                string t = Path.Combine(dDir, subdir.Name);
                if (Directory.Exists(t)) Directory.Delete(t, true);
                CopyDirectory(subdir.FullName, t);
            }
        }


    }
}
