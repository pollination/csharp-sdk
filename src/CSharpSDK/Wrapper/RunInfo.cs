 extern alias LBTRestSharp; using System;
using PollinationSDK.Api;
using PollinationSDK;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Pollination;

namespace PollinationSDK.Wrapper
{
    public class RunInfo
    {
        private static Microsoft.Extensions.Logging.ILogger Logger => LogUtils.GetLogger<RunInfo>();
        public bool IsLocalRun => !Guid.TryParse(this.RunID, out var res);
        public bool IsCloudRunDone => this.Run.Status.FinishedAt >= this.Run.Status.StartedAt;
        public string CloudRunStatus => this.Run.Status.Status.ToString();
        public string RunID => this.Run.Id;
        public Run Run { get; private set; }
        //public Project Project { get; private set; }
        public UserPermission ProjectCloudPermission { get; private set; }
        public string ProjectOwner { get; private set; }
        public string ProjectName { get; private set; }
        public string ProjectSlug => $"{ProjectOwner}/{ProjectName}";
        public string RunSlug => $"{ProjectSlug}/{RunID}";
        public string JobId { get; set; }
        public RecipeInterface Recipe { get; private set; }

        //[IgnoreDataMember]
        //public string Logs { get; set; }
        public RunInfo(Project proj, string runID) : this(proj, GetRun(proj, runID))
        {
        }

        public RunInfo(Project proj, Run run)
        {
            this.Run = run;
            this.ProjectCloudPermission = proj.Permissions;
            this.ProjectOwner = proj.Owner.Name;
            this.ProjectName = proj.Name;
            this.Recipe = this.Run.Recipe;
        }

        //public RunInfo(string projOwner, string projName, RecipeInterface recipe, string localRunPath)
        //{
        //    var localPath = Path.GetFullPath(localRunPath);
        //    this.Run = new Run(localPath);
        //    this.Recipe = recipe;
        //}
        public RunInfo(JobInfo localJob)
        {
            this.Run = new Run(localJob.LocalRunOutputFolder);
            var proj = localJob.ProjectSlug.Split('/');
            this.ProjectOwner = proj[0];
            this.ProjectName = proj[1];
            this.Recipe = localJob.Recipe;
        }

        public RunInfo(ScheduledJobInfo localJob)
        {
            this.Run = new Run(localJob.SavedLocalPath);
            var proj = localJob.ProjectSlug.Split('/');
            this.ProjectOwner = proj[0];
            this.ProjectName = proj[1];
            this.Recipe = localJob.Recipe;

        }

        public RunInfo(string localRunFolder)
            : this(ScheduledJobInfo.From(localRunFolder))
        {

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
                return $"CLOUD:{this.RunSlug}";
            return $"LOCAL:{this.RunID}";

        }

        public string GetStatusMessage()
        {
            var s = this.Run.Status;
            return $"Status: {s.Status}; {s.Message}";
        }


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

        private static RecipeInterface GetRecipe(string owner, string name, string tag = default)
        {
            var api = new Api.RecipesApi();
            var tagToSearch = tag;
            if (string.IsNullOrEmpty(tagToSearch) || tagToSearch == "*")
            {
                tagToSearch = "latest";
            }

            var rec = api.GetRecipeByTag(owner, name, tagToSearch);
            return rec.Manifest;
        }



        public List<Interface.Io.Outputs.IDag> GetOutputs() => this.Recipe.GetOutputs();

        private List<Interface.Io.Inputs.IStep> GetLocalInputs()
        {
            if (!this.IsLocalRun)
                throw new ArgumentException("This is not a local run");

            var folder = this.RunID;
            var file = Path.Combine(folder, "inputs.json");
            var json = File.ReadAllText(file);
            var args = LBT.Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            var recipeInputs = this.Recipe.InputList.ToList();
            var stepInputs = new Interface.Io.Inputs.IStep[recipeInputs.Count];
            var userInputs = new List<Interface.Io.Inputs.IStep>();
            foreach (var arg in args)
            {
                var argName = arg.Key;
                var reciptInputIndex = recipeInputs.FindIndex(_ => _.Name == argName);
                if (reciptInputIndex >= 0)
                {
                    var reciptInput = recipeInputs[reciptInputIndex];
                    var value = arg.Value;
                    if (value == null)
                        value = reciptInput.GetDefaultValue();
                    if (reciptInput.Required == false && value == null)
                        continue;
                    var sinput = reciptInput.ToStepInput(value);
                    stepInputs[reciptInputIndex] = sinput;
                }
                else
                {
                    // users string input
                    var value = arg.Value;
                    var sinput = new StepStringInput(argName, value?.ToString());
                    userInputs.Add(sinput);

                }

            }
            var allInputs = stepInputs.Concat(userInputs).Where(_ => _ != null).ToList();
            return allInputs;
        }

        public List<Interface.Io.Inputs.IStep> GetInputs()
        {
            var inputs =
                this.IsLocalRun ?
                GetLocalInputs() :
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
            var assets = this.GetOutputs().Select(_ => new RunOutputAsset(_, platform, sourcelink) { RunInfo = this }).ToList();
            return assets;
        }


        /// <summary>
        /// Get a run's input assets
        /// </summary>
        /// <returns></returns>
        public List<RunInputAsset> GetInputAssets()
        {
            var sourcelink = this.ToString();
            var assets = this.GetInputs().Select(_ => new RunInputAsset(_, sourcelink) { RunInfo = this }).ToList();
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
                var dup = item.Duplicate() as RunAssetBase;
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
                    var relativeOutPath = output.RelativePath.Replace("/", @"\");
                    relativeOutPath = relativeOutPath.StartsWith(@"\") ? relativeOutPath : $@"\{relativeOutPath}";
                    if (output.IsFile)
                    {
                        var file = Directory.GetFiles(root, "*", SearchOption.AllDirectories).OrderBy(_ => _.Length).FirstOrDefault(_ => _.EndsWith(relativeOutPath));
                        dup.LocalPath = file;
                    }
                    else
                    {
                        //this is an output folder
                        var dir = Directory.GetDirectories(root, "*", SearchOption.AllDirectories).OrderBy(_ => _.Length).FirstOrDefault(_ => _.EndsWith(relativeOutPath));
                        dup.LocalPath = dir;
                    }

                }


                if (!dup.IsSaved())
                    throw new ArgumentException($"Failed to find asset: {relativePath} in {root}");


                dup.LocalPath = Path.GetFullPath(dup.LocalPath);
                // copy to saveAsDir
                if (!string.IsNullOrEmpty(saveAsDir))
                {
                    var jobName = Path.GetFileName(root);
                    var newPath = Path.Combine(saveAsDir, jobName, relativePath);
                    newPath = Path.GetFullPath(newPath);
                    var newRoot = Path.GetDirectoryName(newPath);
                    Directory.CreateDirectory(newRoot);

                    // file type 
                    if (!Helper.IsDirectory(newPath))
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

        public async Task<List<RunAssetBase>> DownloadRunAssetsAsync(List<RunAssetBase> runAssets, string saveAsDir = default, Action<string> reportingAction = default, bool useCached = false, System.Threading.CancellationToken cancelToken = default)
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
                    allAssets = Helper.CheckCached(allAssets, dir).ToList();
                }

                cancelToken.ThrowIfCancellationRequested();
                // assembly download tasks
                reportingAction?.Invoke("Starting");
                var tasks = DownloadAssets(this, allAssets, dir, reportingAction, cancelToken);
                downloadedAssets = (await Task.WhenAll(tasks)).ToList();
                reportingAction?.Invoke("Downloaded");

            }
            catch (Exception e)
            {
                Logger.ThrowError(e);
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




        /// <summary>
        /// Download all assets (input/output) with one call
        /// </summary>
        /// <param name="runInfo"></param>
        /// <param name="saveAsDir"></param>
        /// <returns></returns>
        private static List<Task<RunAssetBase>> DownloadAssets(RunInfo runInfo, IEnumerable<RunAssetBase> assets, string saveAsDir, Action<string> reportProgressAction, System.Threading.CancellationToken cancelToken = default)
        {
            var tasks = new List<Task<RunAssetBase>>();
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

                        Action<int> individualProgress = (percent) =>
                        {
                            reportProgressAction?.Invoke($"{assetName}: {percent}%");
                        };
                        Action overAllProgress = () =>
                        {
                            completed++;
                            reportProgressAction?.Invoke($"OVERALL: {completed}/{total}");
                        };

                        var task = Task.Run(async () =>
                        {
                            var url = string.Empty;

                            if (isInputAsset)
                                url = api.DownloadRunArtifact(runInfo.ProjectOwner, runInfo.ProjectName, runInfo.RunID, path: asset.RelativePath).ToString();
                            else
                                url = api.GetRunOutput(runInfo.ProjectOwner, runInfo.ProjectName, runInfo.RunID, assetName).ToString();

                            Logger.Info($"Downloading {assetName} from \n  -{url}\n");
                            var t = Helper.DownloadUrlAsync(url, dir, individualProgress, overAllProgress, cancelToken);
                            await t.ConfigureAwait(false);
                            var savedFolderOrFilePath = t.Result;
                            Logger.Info($"Saved {assetName} to {savedFolderOrFilePath}");

                            // check folder with single file 
                            savedFolderOrFilePath = Helper.CheckPathForDir(savedFolderOrFilePath);

                            // update saved path
                            var dup = asset.Duplicate() as RunAssetBase;
                            dup.LocalPath = savedFolderOrFilePath;
                            return dup;
                        });
                        tasks.Add(task);

                    }
                    else
                    {
                        tasks.Add(Task.Run(() => asset));
                        completed++;
                    }
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

    }
}
