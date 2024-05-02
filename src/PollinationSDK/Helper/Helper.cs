extern alias LBTNewtonsoft; extern alias LBTRestSharp; using System;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Wrapper;
using LBTRestSharp::RestSharp;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace PollinationSDK
{
    public static class Helper
    {
        public static Serilog.ILogger Logger { get; set; } = Serilog.Log.Logger;
        public static UserPrivate CurrentUser { get; set; }

        public static UserPrivate GetUser()
        {
            var api = new UserApi();
            //var config = api.Configuration;
            var me = api.GetMe();
            return me;
        }

        public static Project GetAProject(string projectSlug)
        {

            if (PollinationSDK.Helper.CurrentUser == null)
            {
                throw new ArgumentException($"Login to Pollination cloud is required!\nPlease right click the component to login first!");
            }

            var projSlug = projectSlug;
            if (!projSlug.Contains('/'))
            {
                projSlug = $"{PollinationSDK.Helper.CurrentUser.Username}/{projSlug}";
            }

            var args = projSlug.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            if (args.Count != 2)
                throw new ArgumentException($"Failed to get a valid project from [{projectSlug}]");
            var projOwner = args.FirstOrDefault();
            var projName = args.LastOrDefault();
            return GetAProject(projOwner, projName);
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
                    Logger.Information($"Project {projectName} is not found in account {userName}. Now creating this project.");
                    var ifPublic = projectName == "demo";
                    var res = api.CreateProject(userName, new ProjectCreate(projectName, _public: ifPublic));
                    return GetAProject(userName, projectName);
                }
                LogHelper.LogError(e, $"Failed to get the project {userName}/{projectName}");
                throw e;
            }


        }

        public static Project GetWritableProject(string projectSlug)
        {
            var p = Helper.GetAProject(projectSlug);
            if (!p.Permissions.Write)
                throw new ArgumentException($"You don't have access to [{p.Slug}] project. Switch to a different project using the SetupRuns component.");

            return p;
        }

        public static async Task<bool> UploadDirectoryAsync(Project project, string directory, Action<int> reportProgressAction = default, CancellationToken cancellationToken = default)
        {
            LogHelper.LogInfo($"Uploading a directory {directory}");
            LogHelper.LogInfo($"Timeout: {Configuration.Default.Timeout}");

            var files = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);
            var api = new ArtifactsApi();

            var total = files.Count();
            LogHelper.LogInfo($"Uploading {total} assets for project {project.Name}");

            var finished = 0;
            var finishedPercent = 0;
            reportProgressAction?.Invoke(finishedPercent);

            var chunkSize = 20;
            var subLists = files.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / chunkSize)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

            Action<int> reportPercent = (c) =>
            {
                var p = finished + c;
                finishedPercent = (int)(p * 100 / total);
                reportProgressAction?.Invoke(finishedPercent);
            };

            foreach (var chunk in subLists)
            {
                var chunkFiles = chunk.Select(_ => (_, _.Replace(directory, ""))).ToList();
                await BatchExecute(api, project, chunkFiles, reportPercent, cancellationToken);
                // auto refresh token between each chunk run
                api.Configuration.TokenRepo?.CheckToken();
                finished += chunk.Count;
            }

            LogHelper.LogInfo($"Finished uploading assets for project {project.Name}");

            // canceled by user
            if (cancellationToken.IsCancellationRequested) return false;

            return true;
        }
        
        private static async Task<bool> BatchExecute(ArtifactsApi api, Project project, List<(string path, string relativePath)> files , Action<int> finishedCountProgressAction = default, CancellationToken cancellationToken = default)
        {
            var tasks = files.Select(_=> UploadArtifactAsync(api, project, _.path, _.relativePath)).ToList();

            var finished = 0;
            while (tasks.Count() > 0)
            {
                // canceled by user
                if (cancellationToken.IsCancellationRequested)
                {
                    LogHelper.LogInfo($"Canceled uploading by user");
                    break;
                }

                var finishedTask = await Task.WhenAny(tasks);
                tasks.Remove(finishedTask);

                if (finishedTask.IsFaulted || finishedTask.Exception != null)
                {
                    LogHelper.LogError($"Upload exception: {finishedTask.Exception}");
                    throw finishedTask.Exception;
                }

                finished++;
                finishedCountProgressAction?.Invoke(finished);

            }

            // canceled by user
            if (cancellationToken.IsCancellationRequested) return false;
            return true;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="fullPath">something like: "C:\Users\mingo\Downloads\Compressed\project_folder\project_folder\model\grid\room.pts"</param>
        /// <param name="relativePath">"model\grid\room.pts"</param>
        public static async Task<bool> UploadArtifactAsync(ArtifactsApi api, Project project, string fullPath, string relativePath)
        {
            var filePath = fullPath;
            var fileRelativePath = relativePath.Replace('\\', '/');
            if (fileRelativePath.StartsWith("/"))
                fileRelativePath = fileRelativePath.Substring(1);

            
            var artf = await api.CreateArtifactAsync(project.Owner.Name, project.Name, new KeyRequest(fileRelativePath));

            //Use RestSharp
            RestClient restClient = new RestClient
            {
                BaseUrl = new Uri(artf.Url),
                Timeout = Configuration.Default.Timeout
            };

            RestRequest restRequest = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            restRequest.AddHeader("Content-Type", "multipart/form-data");

            artf.Fields.Keys.ToList().ForEach(f => restRequest.AddParameter(f, artf.Fields[f]));

            restRequest.AddFile("file", filePath);

            LogHelper.LogInfo($"Started upload of {fileRelativePath}");
            var response = await restClient.ExecuteAsync(restRequest);

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                LogHelper.LogInfo($"Done uploading {fileRelativePath}");
                return true;
            }
            else
            {
                LogHelper.LogInfo($"Received response code: {response.StatusCode}");
                LogHelper.LogInfo($"{response.Content}");
            }
            return false;
        }



        public static IEnumerable<RunAssetBase> CheckCached(IEnumerable<RunAssetBase> assets, string dir)
        {
            var checkedAssets = new List<RunAssetBase>();
            var inputDir = Path.Combine(dir, "inputs");
            var outputDir = Path.Combine(dir, "outputs");
            foreach (var item in assets)
            {
                var savedDir = item is RunInputAsset ? inputDir : outputDir;
                var dupObj = item.Duplicate() as RunAssetBase;
                var isCached = item.CheckIfAssetCached(savedDir);
                if (isCached)
                {
                    var cachedPath = item.GetCachedAsset(savedDir);
                    cachedPath = Helper.CheckPathForDir(cachedPath);
                    dupObj.LocalPath = cachedPath;
                }

                checkedAssets.Add(dupObj);
            }
            return checkedAssets;
        }

        public static IEnumerable<CloudReferenceAsset> CheckCached(IEnumerable<CloudReferenceAsset> assets, string dir)
        {
            var checkedAssets = new List<CloudReferenceAsset>();
            foreach (var item in assets)
            {
                var dupObj = item.Duplicate() as CloudReferenceAsset;
                var cachedPath = Path.GetFullPath(Path.Combine(dir, dupObj.RelativePath));
                //var isCached = dupObj.CheckIfAssetCached(dir);
                if (File.Exists(cachedPath))
                {
                    dupObj.LocalPath = cachedPath;
                }

                checkedAssets.Add(dupObj);
            }
            return checkedAssets;
        }


        public static string CheckPathForDir(string savedFolderOrFilePath)
        {
            var p = savedFolderOrFilePath;
            // check folder
            if (IsDirectory(p))
            {
                var tempDir = new DirectoryInfo(p);
                var subItems = tempDir.GetFileSystemInfos("*", SearchOption.TopDirectoryOnly);

                if (subItems.Count() == 1)
                {
                    // if there is only one file/folder inside
                    var f = subItems[0];
                    if (f.Exists) p = f.FullName;
                }
            }

            return p;
        }



        public static bool GetRecipeFromRecipeSourceURL(string recipeSource, out string recipeOwner, out string recipeName, out string recipeVersion)
        {
            recipeOwner = null;
            recipeName = null;
            recipeVersion = null;

            //https://api.staging.pollination.cloud/registries/ladybug-tools/recipe/annual-daylight/0.2.0
            // /registries/ladybug-tools/recipes/daylight-factor/567bbf4cb9e82dd4e266ab131160df8f85596272c6db6913b7cada187db017a5

            //var recipeSource = job.Source;
            if (string.IsNullOrEmpty(recipeSource)) return false;
            string pattern = @"(?=[\w\W]*)\/registries\/[\w\d-]*\/recipes?\/[\w\d-]*\/[\d\w.-]*";
            var m = System.Text.RegularExpressions.Regex.Match(recipeSource, pattern);
            if (!m.Success) return false;

            // /registries/ladybug-tools/recipe/annual-daylight/0.2.0-viz
            recipeVersion = m.Value;

            var items = recipeVersion.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (items.Count() != 5) return false;
            recipeOwner = items[1];
            recipeName = items[3];
            recipeVersion = items[4];
            return true;
        }

        public static bool IsDirectory(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            var isDir = attr.HasFlag(FileAttributes.Directory);
            return isDir;
        }


        /// <summary>
        /// Download all cloud reference assets (file or folder) from a project folder
        /// </summary>
        /// <param name="projSlug"></param>
        /// <param name="assets"></param>
        /// <param name="saveAsDir"></param>
        /// <param name="reportProgressAction"></param>
        /// <param name="useCached"></param>
        /// <param name="cancelToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static async Task<List<CloudReferenceAsset>> DownloadAssetsAsync(string projSlug, IEnumerable<CloudReferenceAsset> assets, string saveAsDir, Action<string> reportProgressAction, bool useCached = false, System.Threading.CancellationToken cancelToken = default)
        {
            var tasks = new List<CloudReferenceAsset>();
            if (assets == null || !assets.Any()) return tasks;


            var dir = Path.GetFullPath(Path.Combine(saveAsDir, projSlug));
            System.IO.Directory.CreateDirectory(dir);

            var api = new PollinationSDK.Api.ArtifactsApi();

            var proj = projSlug.Split('/');
            var projOwner = proj[0];
            var projName = proj[1];

            // check folder assets
            var gp = assets.GroupBy(_ => _.IsFolder);
            var fileAssets = gp.FirstOrDefault(_ => _.Key == false)?.Select(_ => _)?.ToList() ?? new List<CloudReferenceAsset>();
            var folderAssets = gp.FirstOrDefault(_ => _.Key == true)?.Select(_ => _.RelativePath)?.ToList();
            if (folderAssets != null && folderAssets.Any())
            {
                var allFiles = await GetAllFilesAsync(api, projOwner, projName, folderAssets, saveAsDir);
                var cloudRefs = allFiles.Select(_ => new CloudReferenceAsset(projOwner, projName, _.Key, _.FileType));
                fileAssets.AddRange(cloudRefs);
            }

            // check if cached
            if (useCached)
            {
                fileAssets = CheckCached(fileAssets, dir).ToList();
            }

            var total = fileAssets.Count();
            var completed = 0;
            foreach (var asset in fileAssets)
            {
                try
                {
                    if (asset.IsPathAsset() && !asset.IsSaved())
                    {

                        Action<int> individualProgress = (percent) => {
                            reportProgressAction?.Invoke($"[{completed}]: {percent}%");
                        };

                        var savedFolderOrFilePath = await DownloadArtifactAsync(api, projOwner, projName, asset.RelativePath, dir, individualProgress, cancelToken);

                        // check folder with single file 
                        savedFolderOrFilePath = CheckPathForDir(savedFolderOrFilePath);

                        // update saved path
                        var dup = asset.Duplicate() as CloudReferenceAsset;
                        dup.LocalPath = savedFolderOrFilePath;
                        tasks.Add(dup);
                    }
                    else
                    {
                        tasks.Add(asset);
                    }

                    completed++;
                }
                catch (Exception e)
                {
                    //canceled by user
                    if (e is OperationCanceledException)
                        return null;

                    throw new ArgumentException($"Failed to download asset {asset.Name}.\n -{e.Message}");
                }
            }
            return tasks;

        }

        public static async Task<List<CloudReferenceAsset>> DownloadAssetsAsync(string projSlug, string jobId, IEnumerable<CloudReferenceAsset> assets, string saveAsDir, Action<string> reportProgressAction, bool useCached = false, System.Threading.CancellationToken cancelToken = default)
        {
            var tasks = new List<CloudReferenceAsset>();
            if (assets == null || !assets.Any()) return tasks;


            var dir = Path.GetFullPath(Path.Combine(saveAsDir, projSlug));
            System.IO.Directory.CreateDirectory(dir);


            var proj = projSlug.Split('/');
            var projOwner = proj[0];
            var projName = proj[1];

            // check folder assets
            var gp = assets.GroupBy(_ => _.IsFolder);
            var fileAssets = gp.FirstOrDefault(_ => _.Key == false)?.Select(_ => _)?.ToList() ?? new List<CloudReferenceAsset>();
            var folderAssets = gp.FirstOrDefault(_ => _.Key == true)?.Select(_ => _.RelativePath)?.ToList();

            var api = new PollinationSDK.Api.JobsApi();
            if (folderAssets != null && folderAssets.Any())
            {
                var allFiles = await GetAllFilesAsync(api, projOwner, projName, jobId, folderAssets, saveAsDir);
                var cloudRefs = allFiles.Select(_ => new CloudReferenceAsset(projOwner, projName, jobId, _.Key, _.FileType));
                fileAssets.AddRange(cloudRefs);
            }

            // check if cached
            if (useCached)
            {
                fileAssets = CheckCached(fileAssets, dir).ToList();
            }

            var total = fileAssets.Count();
            var completed = 0;
            foreach (var asset in fileAssets)
            {
                try
                {
                    if (asset.IsPathAsset() && !asset.IsSaved())
                    {

                        Action<int> individualProgress = (percent) => {
                            reportProgressAction?.Invoke($"[{completed}]: {percent}%");
                        };

                        var savedFolderOrFilePath = await DownloadArtifactAsync(api, projOwner, projName, jobId, asset.RelativePath, dir, individualProgress, cancelToken);

                        // check folder with single file 
                        savedFolderOrFilePath = CheckPathForDir(savedFolderOrFilePath);

                        // update saved path
                        var dup = asset.Duplicate() as CloudReferenceAsset;
                        dup.LocalPath = savedFolderOrFilePath;
                        tasks.Add(dup);
                    }
                    else
                    {
                        tasks.Add(asset);
                    }

                    completed++;
                }
                catch (Exception e)
                {
                    //canceled by user
                    if (e is OperationCanceledException)
                        return null;

                    throw new ArgumentException($"Failed to download asset {asset.Name}.\n -{e.Message}");
                }
            }
            return tasks;

        }



        /// <summary>
        /// List all FileMeta from all sub-folders if exists
        /// </summary>
        /// <param name="api"></param>
        /// <param name="projOwner"></param>
        /// <param name="projName"></param>
        /// <param name="relativeFolderPaths"></param>
        /// <param name="saveAsDir"></param>
        /// <param name="reportProgressAction"></param>
        /// <param name="cancelToken"></param>
        /// <returns></returns>
        public static async Task<List<FileMeta>> GetAllFilesAsync(ArtifactsApi api, string projOwner, string projName, List<string> relativeFolderPaths, string saveAsDir)
        {
            var fs = api.ListArtifacts(projOwner, projName, relativeFolderPaths, null, 500).Resources;
            var gp = fs.GroupBy(_ => _.FileType == "folder");
            var files = gp.FirstOrDefault(_ => _.Key == false)?.Select(_ => _)?.ToList() ?? new List<FileMeta>();
            var folders = gp.FirstOrDefault(_=>_.Key == true)?.Select(_ => _.Key)?.ToList() ?? new List<string>();
            if (folders.Any())
            {
                var subItems = await GetAllFilesAsync(api, projOwner, projName, folders, saveAsDir);
                files.AddRange(subItems);
            }
            return files;

        }

        public static async Task<List<FileMeta>> GetAllFilesAsync(JobsApi api, string projOwner, string projName, string jobId, List<string> relativeFolderPaths, string saveAsDir)
        {
            var fs = api.SearchJobFolder(projOwner, projName, jobId, relativeFolderPaths, null, 500).Resources;
            var gp = fs.GroupBy(_ => _.FileType == "folder");
            var files = gp.FirstOrDefault(_ => _.Key == false)?.Select(_ => _)?.ToList() ?? new List<FileMeta>();
            var folders = gp.FirstOrDefault(_ => _.Key == true)?.Select(_ => _.Key)?.ToList() ?? new List<string>();
            if (folders.Any())
            {
                var subItems = await GetAllFilesAsync(api, projOwner, projName, jobId, folders, saveAsDir);
                files.AddRange(subItems);
            }
            return files;

        }


        /// <summary>
        /// Download file artifacts from a project folder
        /// </summary>
        /// <param name="relativePath">"model\grid\room.pts"</param>
        public static async Task<string> DownloadArtifactAsync(ArtifactsApi api, string projOwner, string projName, string relativePath, string saveAsDir, Action<int> reportProgressAction = default, System.Threading.CancellationToken cancelToken = default)
        {
            var fileRelativePath = relativePath.Replace('\\', '/');
            if (fileRelativePath.StartsWith("/"))
                fileRelativePath = fileRelativePath.Substring(1);

            var url = (await api.DownloadArtifactAsync(projOwner, projName, fileRelativePath))?.ToString();

            LogHelper.LogInfo($"Downloading {fileRelativePath} from \n  -{url}\n");
            // get relative path correct
            saveAsDir = Path.GetDirectoryName(Path.Combine(saveAsDir, relativePath));
            saveAsDir = Path.GetFullPath(saveAsDir);
            var path = await Helper.DownloadUrlAsync(url.ToString(), saveAsDir, reportProgressAction, null, cancelToken);

            LogHelper.LogInfo($"Saved {fileRelativePath} to {path}");
            return path;
        }

        public static async Task<string> DownloadArtifactAsync(JobsApi api, string projOwner, string projName, string jobId, string relativePath, string saveAsDir, Action<int> reportProgressAction = default, System.Threading.CancellationToken cancelToken = default)
        {
            var fileRelativePath = relativePath.Replace('\\', '/');
            if (fileRelativePath.StartsWith("/"))
                fileRelativePath = fileRelativePath.Substring(1);

            var url = (await api.DownloadJobArtifactAsync(projOwner, projName, jobId, fileRelativePath, cancelToken))?.ToString();

            LogHelper.LogInfo($"Downloading {fileRelativePath} from \n  -{url}\n");
            // get relative path correct
            saveAsDir = Path.GetDirectoryName(Path.Combine(saveAsDir, relativePath));
            saveAsDir = Path.GetFullPath(saveAsDir);
            var path = await Helper.DownloadUrlAsync(url.ToString(), saveAsDir, reportProgressAction, null, cancelToken);

            LogHelper.LogInfo($"Saved {fileRelativePath} to {path}");
            return path;
        }


        public static async Task<string> DownloadArtifactAsync(Project proj, FileMeta file, string saveAsFolder, Action<int> reportProgressAction = default)
        {
            var api = new ArtifactsApi();
            var saved = await DownloadArtifactAsync(api, proj.Owner.Name, proj.Name, file.Key, saveAsFolder, reportProgressAction);
            return saved;
        }


        private static async Task<List<string>> Download(string url, string dir, Action<int> reportProgressAction)
        {

            try
            {
                // downloaded folder
                var task = DownloadUrlAsync(url, dir, reportProgressAction);
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

        private static async Task<List<string>> DownloadArtifactZip(RunInfo runInfo, string zipFileName, string saveAsDir = default, Action<int> reportProgressAction = default)
        {
            try
            {
                var simuApi = new PollinationSDK.Api.RunsApi();

                var url = simuApi.DownloadRunArtifact(runInfo.ProjectOwner, runInfo.ProjectName, runInfo.RunID, zipFileName).ToString();

                var dir = string.IsNullOrEmpty(saveAsDir) ? GenTempFolder() : saveAsDir;
                var simuID = runInfo.RunID.Substring(0, 8);
                dir = Path.Combine(dir, simuID);
                // downloaded folder
                return await Download(url, dir, reportProgressAction);
            }
            catch (Exception)
            {
                throw;
            }

        }
        private static async Task<List<string>> DownloadSimulationInputAssets(RunInfo runInfo, string saveAsDir = default, Action<int> reportProgressAction = default)
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
                return await Download(url, dir, reportProgressAction);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static async Task<string> DownloadUrlAsync(string url, string saveAsDir, Action<int> reportProgressAction = default, Action whenDone = default, System.Threading.CancellationToken cancelToken = default)
        {  
            // prep file path
            var fileName = Path.GetFileName(url).Split(new[] { '?' })[0];

            Directory.CreateDirectory(saveAsDir);
            var file = Path.Combine(saveAsDir, fileName);
            LogHelper.LogInfo($"Downloading {url}");
            using (WebClient wc = new WebClient())
            {
                var prog = 0;
                wc.DownloadProgressChanged += (s, e) =>
                {
                    if (prog == e.ProgressPercentage)
                        return;
                    prog = e.ProgressPercentage;
                    reportProgressAction?.Invoke(prog);
                };
                wc.DownloadFileCompleted += (s, e) => whenDone?.Invoke();
            

                try
                {    
                    cancelToken.ThrowIfCancellationRequested();
                    cancelToken.Register(wc.CancelAsync);

                    var t = wc.DownloadFileTaskAsync(new Uri(url), file);
                    await t;
                    if (t.IsFaulted && t.Exception != null)
                        throw t.Exception;
                    LogHelper.LogInfo($"Saved {fileName} to {file}");
                }
                catch (WebException ex) when (ex.Status == WebExceptionStatus.RequestCanceled)
                {
                    throw new OperationCanceledException();
                }
                catch (AggregateException ex) when (ex.InnerException is WebException exWeb && exWeb.Status == WebExceptionStatus.RequestCanceled)
                {
                    throw new OperationCanceledException();
                }
                catch (TaskCanceledException)
                {
                    throw new OperationCanceledException();
                }

                
            }

            if (!File.Exists(file))
            {
                throw LogHelper.LogReturnError($"Failed to download {fileName}");
            }
            var outputDirOrFile = file;

            // unzip
            try
            {
                if (file.ToLower().EndsWith(".zip")) outputDirOrFile = Helper.Unzip(file, saveAsDir, true);
            }
            catch (Exception e)
            {
                throw LogHelper.LogReturnError(e, $"Unable to unzip file {Path.GetFileName(file)}");
            }

            return outputDirOrFile;
        }

     

        /// <summary>
        /// Download an artifact(file/folder) items independently.
        /// </summary>
        /// <param name="simu"></param>
        /// <param name="artifact"></param>
        /// <param name="saveAsDir"></param>
        /// <returns></returns>
        private static List<Task<string>> DownloadArtifactWithItems(RunInfo simu, DAGPathOutput artifact, string saveAsDir, Action<int> reportProgressAction)
        {
            var file = string.Empty;
            var outputDirOrFile = string.Empty;
            try
            {
                var api = new PollinationSDK.Api.RunsApi();
                var files = api.ListRunArtifacts(simu.ProjectOwner, simu.ProjectName, simu.RunID, page: 1, perPage: 100).Resources;
                var found = files.FirstOrDefault(_ => _.FileName == artifact.Name);
                if (found == null) throw new ArgumentException($"{artifact.Name} doesn't exist in {simu.RunSlug}");

                var dir = string.IsNullOrEmpty(saveAsDir) ? GenTempFolder() : saveAsDir;
                var simuID = simu.RunID.Substring(0, 8);

                var tasks = new List<Task<string>>();
                dir = Path.Combine(dir, simuID);
                ListFilesFromFolder(ref tasks, dir, simu.ProjectOwner, simu.ProjectName, simu.RunID, found, api);

                return tasks;

            }
            catch (Exception e)
            {
                throw new ArgumentException($"Failed to download artifact {artifact.Name}.\n -{e.Message}");
            }

            // loop through files in folder
            void ListFilesFromFolder(ref List<Task<string>> ts, string saveDir, string owner, string projName, string simuID, FileMeta artfact, RunsApi RunsApi)
            {
                var dir = saveDir;
                var api = RunsApi;
                if (artfact.Type == "file")
                {
                    var url = api.DownloadRunArtifact(owner, projName, simuID, artfact.Key).ToString();
                    var task = DownloadUrlAsync(url, dir, reportProgressAction);
                    ts.Add(task);
                }
                else if (artfact.Type == "folder")
                {
                    dir = Path.Combine(dir, artfact.FileName);
                    var files = api.ListRunArtifacts(owner, projName, simuID, page: 1, perPage: 100, path: new[] { artifact.Name }.ToList()).Resources;
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
                        var task = DownloadUrlAsync(url, dir, reportProgressAction);

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


            return outputDirOrFile;
        }

        //https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories?redirectedfrom=MSDN
        internal static void CopyDirectory(string sDir, string dDir)
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


        /// <summary>
        /// Execute *.sh file on Mac or *.bat on Windows
        /// </summary>
        /// <param name="scriptFile"></param>
        public static void RunScriptFile(string scriptFile, bool silentMode)
        {
            if (!Utilities.IsMac)
            {
                //Windows
                var pInfo = new System.Diagnostics.ProcessStartInfo(scriptFile);
                if (silentMode) 
                    pInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                var p = System.Diagnostics.Process.Start(pInfo);
                
                p.WaitForExit();
            }
            else //Mac
            {
                var chmod = new System.Diagnostics.Process
                {
                    StartInfo = {
                        FileName = @"/bin/bash",
                        Arguments = string.Format("-c \"chmod 777 {0}\"", scriptFile),
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                chmod.Start();
                chmod.WaitForExit();

                //Catalina and Big Sur.
                var terminalMac = @"/System/Applications/Utilities/Terminal.app/Contents/MacOS/Terminal";
                // old mac os
                terminalMac = File.Exists(terminalMac) ? terminalMac : @"/Applications/Utilities/Terminal.app/Contents/MacOS/Terminal";

                var p = new System.Diagnostics.Process
                {
                    StartInfo = {
                        FileName = terminalMac,
                        Arguments = scriptFile,
                        UseShellExecute = false,
                        CreateNoWindow = false,
                        WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                    }
                };

                p.Start();
                p.WaitForExit();
            }

        }


        public delegate bool ExeCommandFunc(string program, string arg, bool silentMode, out string results);

        public static ExeCommandFunc ExeCommandHandler = null;

        public static bool RunCommand(string programPath, string argument, bool silentMode, out string results)
        {
            if (ExeCommandHandler == null)
                throw new ArgumentNullException("Set Helper.ExeCommandHandler first!");

            return ExeCommandHandler(programPath, argument, silentMode, out results);

        }


    }
}
