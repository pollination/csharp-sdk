﻿using PollinationSDK.Api;
using PollinationSDK;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PollinationSDK.Wrapper
{
    public class RunInfo
    {
        public string RunID => this.Run.Id;
        public Run Run { get; private set; }
        public Project Project { get; private set; }
        public RecipeInterface Recipe { get; private set; }

        //[IgnoreDataMember]
        //public string Logs { get; set; }
        public RunInfo(Project proj, string runID): this(proj, GetRun(proj, runID))
        {
        }

        public RunInfo(Project proj, Run run)
        {
            this.Run = run;
            this.Project = proj;
            this.Recipe = this.Run.Recipe;
        }

        public RunInfo(RecipeInterface recipe , string localRunPath)
        {
            var localPath = Path.GetFullPath(localRunPath);
            this.Run = new Run(localPath);
            this.Recipe = recipe;
        }

        private static Run GetRun(Project proj, string runID)
        {
            var api = new RunsApi();
            var run = api.GetRun(proj.Owner.Name, proj.Name, runID.ToString());
            return run;
        }

        //private static RecipeInterface GetRecipe(string url)
        //{
        //    Helper.GetRecipeFromRecipeSourceURL(url, out var recipe);
        //    return recipe;
        //}


        public override string ToString()
        {
            if (!IsLocalRun)
                return $"CLOUD:{this.Project.Owner.Name}/{this.Project.Name}/{this.RunID}";
            return $"LOCAL:{this.RunID}";

        }

        public bool IsLocalRun => !Guid.TryParse(this.RunID, out var res);

        //public async Task<string> WatchRunStatusAsync(Action<string> progressAction = default, System.Threading.CancellationToken cancelToken = default)
        //{
        //    var api = new RunsApi();
        //    var proj = this.Project;
        //    var simuId = this.RunID;
        //    var run = api.GetRun(proj.Owner.Name, proj.Name, simuId);
        //    var status = run.Status;
        //    var startTime = status.StartedAt;
        //    while (status.FinishedAt <= status.StartedAt)
        //    {
        //        var currentSeconds = Math.Round((DateTime.UtcNow - startTime).TotalSeconds);
        //        // wait 5 seconds before calling api to re-check the status
        //        var isCreatedOrScheduled = status.Status == RunStatusEnum.Created || status.Status == RunStatusEnum.Scheduled;
        //        var totalDelaySeconds = isCreatedOrScheduled ? 3 : 5;
        //        for (int i = 0; i < totalDelaySeconds; i++)
        //        {
        //            // suspended by user
        //            cancelToken.ThrowIfCancellationRequested();

        //            progressAction?.Invoke($"{status.Status}: [{GetUserFriendlyTimeCounter(TimeSpan.FromSeconds(currentSeconds))}]");
        //            await Task.Delay(1000);
        //            currentSeconds++;
        //        }
        //        // suspended by user
        //        cancelToken.ThrowIfCancellationRequested();

        //        // update status
        //        await Task.Delay(1000);
        //        run = api.GetRun(proj.Owner.Name, proj.Name, simuId);
        //        status = run.Status;
        //        //_simulation = new Simulation(proj, simuId);
        //    }
        //    this.Run = run;
        //    // suspended by user
        //    cancelToken.ThrowIfCancellationRequested();

        //    var totalTime = status.FinishedAt - startTime;
        //    var finishMessage = status.Status.ToString();
        //    //progressAction?.Invoke($"Task: {status.Status}");

        //    finishMessage = $"{finishMessage}: [{GetUserFriendlyTimeCounter(totalTime)}]";
        //    progressAction?.Invoke(finishMessage);
        //    return finishMessage;

        //    string GetUserFriendlyTimeCounter(TimeSpan timeDelta)
        //    {
        //        string format = @"hh\:mm\:ss";
        //        if (timeDelta.Days > 0)
        //            format = @"d\ hh\:mm\:ss";
        //        else if (timeDelta.Hours > 0)
        //            format = @"hh\:mm\:ss";
        //        else if (timeDelta.Minutes > 0)
        //            format = @"mm\:ss";
        //        else
        //            format = @"ss";
        //        return timeDelta.ToString(format);
        //    }
        //}





        ///// <summary>
        ///// Download all log for a simulation and combine it into one text format
        ///// </summary>
        ///// <param name="progressAction"></param>
        ///// <param name="cancelToken"></param>
        ///// <returns></returns>
        //public async Task<string> GetSimulationOutputLogAsync(Action<string> progressAction = default, System.Threading.CancellationToken cancelToken = default)
        //{
        //    // get task log ids 
        //    if (cancelToken.IsCancellationRequested) return string.Empty;
        //    progressAction?.Invoke($"Getting log IDs");
        //    var proj = this.Project;
        //    var simuId = this.RunID;
        //    var api = new RunsApi();
        //    var job = api.GetRun(proj.Owner.Name, proj.Name, simuId);
        //    var status = job.Status;
        //    if (status.Status == "Running") throw new ArgumentException("Simulation is still running, please wait until it's done!");
        //    var taskDic = status.Steps.OrderBy(_ => _.Value.StartedAt).ToDictionary(_ => _.Key, _ => $"[{_.Key}]\n{_.Value.StartedAt.ToLocalTime()} : {_.Value.Name}");
        //    var taskIDs = taskDic.Keys;

        //    //Download file
        //    if (cancelToken.IsCancellationRequested) return string.Empty;
        //    progressAction?.Invoke($"Downloading logs");

        //    //var url = api.GetSimulationLogs(proj.Owner.Name, proj.Name, simuId).ToString();
        //    var url = "";
        //    if (string.IsNullOrEmpty(url)) throw new ArgumentNullException("Failed to call GetSimulationLogs");
        //    var dir = Path.Combine(Helper.GenTempFolder(), simuId);
        //    var downloadfile = await Helper.DownloadFromUrlAsync(url, dir);


        //    //unzip file 
        //    if (cancelToken.IsCancellationRequested) return string.Empty;
        //    progressAction?.Invoke($"Reading logs");
        //    Helper.Unzip(downloadfile, dir, true);



        //    //read logs
        //    if (cancelToken.IsCancellationRequested) return string.Empty;
        //    var taskFiles = Directory.GetFiles(dir, "*.log", SearchOption.AllDirectories);
        //    var totalCount = taskIDs.Count;
        //    var current = 0;
        //    foreach (var logFile in taskFiles)
        //    {
        //        if (cancelToken.IsCancellationRequested) break;

        //        var logID = new DirectoryInfo(Path.GetDirectoryName(logFile)).Name;
        //        if (!taskIDs.Contains(logID)) continue;

        //        var logHeader = taskDic[logID];
        //        var logContent = File.ReadAllText(logFile);
        //        logContent = string.IsNullOrWhiteSpace(logContent) ? "No log available for this task." : logContent;
        //        taskDic[logID] = $"{logHeader} \n{logContent}";
        //        current++;

        //        progressAction?.Invoke($"Reading logs [{current}/{totalCount}]");
        //    }

        //    var fullLog = string.Join("\n\n", taskDic.Values);
        //    return fullLog;
        //}

        //private static async Task<string> DownloadFile(string url, string dir)
        //{
        //    var request = new RestRequest(Method.GET);
        //    var client = new RestClient(url.ToString());
        //    var response = await client.ExecuteAsync(request);
        //    if (response.StatusCode != HttpStatusCode.OK)
        //        throw new Exception($"Unable to download file");

        //    // prep file path
        //    var fileName = Path.GetFileName(url).Split(new[] { '?' })[0];
        //    var tempDir = string.IsNullOrEmpty(dir) ? Path.Combine(Path.GetTempPath(), "Pollination", Path.GetRandomFileName()) : dir;
        //    Directory.CreateDirectory(tempDir);
        //    var file = Path.Combine(tempDir, fileName);

        //    var b = response.RawBytes;
        //    File.WriteAllBytes(file, b);

        //    if (!File.Exists(file)) throw new ArgumentException($"Failed to download {fileName}");
        //    return file;
        //}

        //private static void CheckOutputLogs(RunsApi api, Project proj, string simuId)
        //{
        //    //var api = new RunsApi();
        //    var steps = api.GetRunSteps(proj.Owner.Name, proj.Name, simuId.ToString());
        //    foreach (var item in steps.Resources)
        //    {
        //        var stepLog = api.GetRunStepLogs(proj.Owner.Name, proj.Name, simuId.ToString(), item.Id);
        //        Console.WriteLine(stepLog);
        //    }

        //}

        /// <summary>
        /// Load a RunInfo from a local run's folder.
        /// This folder must contains recipe.json for RecipeInterface, and input.json for input arguments
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public static RunInfo LoadFromLocalFolder(string folder)
        {
            RunInfo runInfo = null;
            if (Directory.Exists(folder))
            {
                var recipeFile = Path.Combine(folder, "recipe.json");
                var recipeJson = File.ReadAllText(recipeFile);
                var recipe = RecipeInterface.FromJson(recipeJson);
                runInfo = new RunInfo(recipe, folder);
            }
            return runInfo;
           
        }


        public List<Interface.Io.Outputs.IDag> GetOutputs() => this.Recipe.GetOutputs();

        private List<Interface.Io.Inputs.IStep> GetLocalInputs()
        {
            if (!this.IsLocalRun)
                throw new ArgumentException("This is not a local run");

            var folder = this.RunID;
            var file = Path.Combine(folder, "inputs.json");
            var json = File.ReadAllText(file);
            var args = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            var recipeInputs = this.Recipe.InputList;
            var stepInputs = new List<Interface.Io.Inputs.IStep>();
            foreach (var input in recipeInputs)
            {
                if (!args.TryGetValue(input.Name, out var value))
                    value = input.GetDefaultValue();

                if (input.Required == false && value == null)
                    continue;

                var sinput =  input.ToStepInput(value);
                stepInputs.Add(sinput);
            }

            return stepInputs;
        }

        public List<Interface.Io.Inputs.IStep> GetInputs()
        {
            var inputs = 
                this.IsLocalRun ? 
                GetLocalInputs(): 
                this.Run.Status.Inputs
                  .OfType<Interface.Io.Inputs.IStep>().ToList();

            return inputs;

        }


        /// <summary>
        /// Get a run's output assets
        /// </summary>
        /// <returns></returns>
        public List<RunOutputAsset> GetOutputAssets(string platform)
        {
            var sourcelink = this.ToString();
            var assets = this.GetOutputs().Select(_ => new RunOutputAsset(_, platform, sourcelink)).ToList();
            return assets;
        }


        /// <summary>
        /// Get a run's input assets
        /// </summary>
        /// <returns></returns>
        public List<RunInputAsset> GetInputAssets()
        {
            var sourcelink = this.ToString();
            var assets = this.GetInputs().Select(_ => new RunInputAsset(_, sourcelink)).ToList();
            return assets;

        }

        public List<RunAssetBase> LoadLocalRunAssets(List<RunAssetBase> runAssets, string saveAsDir = default)
        {
            var root = this.RunID; // local folder path
            if (!Directory.Exists(root))
                throw new ArgumentException($"Failed to find the local folder {root}");

            var updatedAssets = new List<RunAssetBase>();
            foreach (var item in runAssets)
            {
                var dup = item.Duplicate();
                if (!dup.IsPathAsset())
                {
                    updatedAssets.Add(dup);
                    continue;
                }
                 
                var relativePath = dup.RelativePath;
                if (dup is RunInputAsset input)
                {
                    dup.LocalPath = Path.Combine(root, relativePath);
                }
                else if (dup is RunOutputAsset output)
                {
                    //this.Run
                    var fd = Directory.GetDirectories(root).FirstOrDefault();
                    dup.LocalPath = Path.Combine(fd, relativePath);
                }


                if (!dup.IsSaved())
                    throw new ArgumentException($"Failed to find asset: {dup.LocalPath}");
               

                dup.LocalPath = Path.GetFullPath(dup.LocalPath);
                // copy to saveAsDir
                if (!string.IsNullOrEmpty(saveAsDir))
                {
                    var jobName = Path.GetFileName(root);
                    var newPath = Path.Combine(saveAsDir, jobName,  relativePath);
                    newPath = Path.GetFullPath(newPath);
                    var newRoot = Path.GetDirectoryName(newPath);
                    Directory.CreateDirectory(newRoot);

                    // file type 
                    if (Path.HasExtension(newPath))
                    {
                        File.Copy(dup.LocalPath, newPath, true);
                    }
                    else //folder type
                    {
                        Helper.CopyDirectory(dup.LocalPath, newPath);
                    }
                    dup.LocalPath = newPath;
                }

                updatedAssets.Add(dup);
            }
            return updatedAssets;
        }

        public async Task<List<RunAssetBase>> DownloadRunAssetsAsync(List<RunAssetBase> runAssets, string saveAsDir = default, Action<string> reportingAction = default, bool useCached = false)
        {

            if (this.IsLocalRun)
                throw new System.ArgumentException("This is a local run, please use LoadLocalRunAssets() to load local assets");
            var downloadedAssets = new List<RunAssetBase>();

            try
            {
                var dir = string.IsNullOrEmpty(saveAsDir) ? Helper.GenTempFolder() : saveAsDir;
                var simuID = this.RunID.Substring(0, 8);
                dir = Path.Combine(dir, simuID);
                
                var allAssets = runAssets;

                // check if cached
                if (useCached)
                {
                    allAssets = CheckCached(allAssets, dir).ToList();
                }

                // assembly download tasks
                reportingAction?.Invoke("Starting");
                var tasks = DownloadAssets(this, allAssets, dir, reportingAction);
                await Task.WhenAll(tasks);
                reportingAction?.Invoke("Downloaded");
                // collect all downloaded assets
                var works = allAssets.Zip(tasks, (asset, saved) => new { asset, saved });
                foreach (var item in works)
                {
                    var dup = item.asset.Duplicate();

                    // get saved path type assets
                    if (item.asset.IsPathAsset())
                    {
                        var savedFolderOrFilePath = await item.saved;
                        // check folder
                        if (!Path.HasExtension(savedFolderOrFilePath))
                        {
                            var tempDir = new DirectoryInfo(savedFolderOrFilePath);
                            var subItems = tempDir.GetFileSystemInfos("*", SearchOption.TopDirectoryOnly);

                            if (subItems.Count() == 1)
                            {
                                // if there is only one file/folder inside
                                var f = subItems[0];
                                if (f.Exists) savedFolderOrFilePath = f.FullName;
                            }
                        }
                        // update saved path
                        dup.LocalPath = savedFolderOrFilePath;
                    }
                    
                    downloadedAssets.Add(dup);
                }

            }
            catch (Exception e)
            {
                Helper.Logger.Error(e, "DownloadRunAssetsAsync");
                throw e;
            }

            return downloadedAssets;

        }

        class DownloadProgress
        {
            public int Total { get; set; }
            public int Completed { get; set; }

            public override string ToString()
            {
                return $"{Completed}/{Total}";
            }
            public bool IsRunning => Total > Completed;
            public bool IsValid => Total > 0;
        }

        private static IEnumerable<RunAssetBase> CheckCached(IEnumerable<RunAssetBase> outputAssets, string dir)
        {
            var checkedAssets = new List<RunAssetBase>();
            var inputDir = Path.Combine(dir, "inputs");
            var outputDir = Path.Combine(dir, "outputs");
            foreach (var item in outputAssets)
            {
                var savedDir = item is RunInputAsset ? inputDir : outputDir;
                var dupObj = item.Duplicate();
                var isCached = item.CheckIfAssetCached(savedDir);
                if (isCached)
                {
                    var cachedPath = item.GetCachedAsset(savedDir);
                    dupObj.LocalPath = cachedPath;
                }

                checkedAssets.Add(dupObj);
            }
            return checkedAssets;
        }


        /// <summary>
        /// Download all assets (input/output) with one call
        /// </summary>
        /// <param name="runInfo"></param>
        /// <param name="saveAsDir"></param>
        /// <returns></returns>
        private static List<Task<string>> DownloadAssets(RunInfo runInfo, IEnumerable<RunAssetBase> assets, string saveAsDir, Action<string> reportProgressAction)
        {
            var tasks = new List<Task<string>>();
            if (assets == null || !assets.Any()) return tasks;
            var api = new PollinationSDK.Api.RunsApi();
            var inputDir = Path.Combine(saveAsDir, "inputs");
            var outputDir = Path.Combine(saveAsDir, "outputs");

            var total = assets.Count();
            var completed = 0;
            foreach (var asset in assets)
            {
                try
                {
                    if (asset.IsPathAsset() && !asset.IsSaved())
                    {
                        var assetName = asset.Name;
                        var isInputAsset = asset is RunInputAsset;
                        var dir = isInputAsset ? inputDir : outputDir;
                        dir = Path.Combine(dir, assetName);

                        Action<int> individualProgress = (percent) => {
                            reportProgressAction?.Invoke($"{assetName}: {percent}%");
                        };
                        Action overAllProgress = () => {
                            completed++;
                            reportProgressAction?.Invoke($"OVERALL: {completed}/{total}");
                        };

                        var task =Task.Run(async ()=> {
                            var url = string.Empty;

                            if (isInputAsset)
                                url = api.DownloadRunArtifact(runInfo.Project.Owner.Name, runInfo.Project.Name, runInfo.RunID, path: asset.RelativePath).ToString();
                            else
                                url = api.GetRunOutput(runInfo.Project.Owner.Name, runInfo.Project.Name, runInfo.RunID, assetName).ToString();
                            var t = Helper.DownloadUrlAsync(url, dir, individualProgress, overAllProgress);
                            await t.ConfigureAwait(false);

                            return t.Result; 
                        });
                        tasks.Add(task);
                       
                    }
                    else
                    {
                        tasks.Add(Task.Run(() => asset.LocalPath));
                        completed++;
                    }
                }
                catch (Exception e)
                {
                    throw new ArgumentException($"Failed to download asset {asset.Name}.\n -{e.Message}");
                }
            }
            return tasks;

        }
       
    }
}
