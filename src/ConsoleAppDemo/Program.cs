using PollinationSDK.Api;
using PollinationSDK.Client;
//using PollinationSDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PollinationSDK;
using PollinationSDK.Wrapper;
using System.Threading;
using Pollination;

namespace ConsoleAppDemo
{
    class Program
    {

        private static Microsoft.Extensions.Logging.ILogger Logger => LogUtils.GetLogger<Program>();
        static void Main(string[] args)
        {

            RunCloudTests();
            Console.ReadKey();

        }


        public static void RunCloudTests()
        {
            Console.WriteLine("Press any key to sign in from the default browser...");
            Console.ReadKey();

            AuthHelper.SignInAsync(devEnv: false).Wait();

            var me = Helper.CurrentUser;
            Console.WriteLine($"You are: {me.Username}");

            Console.WriteLine("What is the Job ID: (\"ProjectOwnerName\"/\"ProjectName\"/\"JobID\". Such as mingbo/demo/1b933dfb-xxxx-4c18-a463-0d273cf42c43)");
            var jobString = Console.ReadLine();
            GetJobHttpInfo(jobString);

            //Console.WriteLine("--------------------Get recipes-------------------");
            //var api = new RecipesApi();
            //var recipeList = api.ListRecipes(1, 25);
            //var recs = recipeList.Resources;
            //foreach (var item in recs)
            //{
            //    Console.WriteLine($"{item.Owner.Name}/{item.Name}/{item.LatestTag}");
            //}


            //Console.WriteLine("--------------------Get projects-------------------");
            //var projApi = new ProjectsApi();
            //var projList = projApi.ListProjects(page: 1, perPage: 25);
            //foreach (var item in projList.Resources)
            //{
            //    Console.WriteLine($"{item.Owner.Name}/{item.Name}/is public: {item.Public}/Admin: {item.Permissions.Admin}");
            //    Console.WriteLine($"{item.Permissions}");
            //}


            //Console.WriteLine("--------------------Get a recipe-------------------");
            //var recipeOwner = "ladybug-tools";
            //var recipeName = "daylight-factor";
            //var recipeApi = new RecipesApi();
            //var rec = recipeApi.GetRecipeByTag(recipeOwner, recipeName, "*").Manifest;
            //Console.WriteLine($"{rec.Source}/{rec.Metadata.Name}/{rec.Metadata.Tag}");


            //Console.WriteLine("--------------------Get a project-------------------");
            //var proj = Helper.GetAProject(me.Username, "demo");
            //Console.WriteLine($"Getting the project. \nFound this project {proj.Name} ID: {proj.Id}");


            //Console.WriteLine("--------------------Getting Recipe Params-------------------");
            //GetRecipeParameters();


            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Creating a project");
            //var proj = CreateAProject(me);


            //Console.WriteLine("--------------------Upload a directory-------------------");
            //var dir = @"C:\Users\mingo\Downloads\Compressed\project_folder\project_folder";
            //var task = Helper.UploadDirectoryAsync(proj, dir);
            //task.Wait();


            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Getting the recipes");
            //var recipies = GetRecipes();
            //Console.WriteLine(string.Join("\n", recipies));


            //Console.WriteLine("---------------------------------------");
            //var projects = GetProjects();
            //Console.WriteLine("Getting the project list");
            //Console.WriteLine(string.Join("\n", projects));


            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine($"Deleting the project {newProj}");
            //DeleteMyProjects(me, newProj);


            //Console.WriteLine("--------------------Creating a new Simulaiton-------------------");
            //ScheduleNewJob(proj);


            //CLOUD:mingbo/demo/1b933dfb-009c-4c18-a463-0d273cf42c43/results#OUT_daylight_factor

            //Console.WriteLine("--------------------get simulation assets-------------------");
            //DownloadAssets(proj);


            //var output2 = runApi.ListRunArtifacts(proj.Owner.Name, proj.Name, run.Id);

            //foreach (var item in output2)
            //{
            //    Console.WriteLine($"{item.FileName}");
            //    var url = runApi.DownloadRunArtifact(proj.Owner.Name, proj.Name, run.Id, item.Key).ToString();
            //    Console.WriteLine(url);
            //}
            //var res = runApi.QueryResults(proj.Owner.Name, proj.Name);

            //Console.WriteLine("Done downloading");


            //Console.WriteLine("--------------------Download simulation output-------------------");
            //var runInfo = new RunInfo(proj, "a211fd95-2830-411a-a4e9-35e4ccbe4eab");
            //DownloadOutputs(runInfo, new List<string> { "results" });
            //Console.WriteLine("Done downloading");


            //Console.WriteLine("--------------------Download simulation log-------------------");
            ////@"C:\\Users\\mingo\\AppData\\Local\\Temp\\Pollination\\9936f815-25f1-40b8-a298-71091dd6b71a\\re4veore.tvs\\logs.tgz"
            //var rapi = new RunsApi();
            //var run = rapi.GetRun("mingbo","demo", "941e9e52-4f98-4dd8-87b9-16129bc38c47");
            //var simu = rapi.GetRunSteps("mingbo", "demo", "941e9e52-4f98-4dd8-87b9-16129bc38c47").Resources;
            ////var simuLog = simu.GetSimulationOutputLogAsync(Console.WriteLine).Result;

            //Console.WriteLine("Done downloading");
            ////Console.WriteLine(simuLog);
            //var entryID = run.Status.Entrypoint;
            //var log = rapi.GetRunStepLogs("mingbo", "demo", "941e9e52-4f98-4dd8-87b9-16129bc38c47", entryID);


            //DownloadBigAssetTest();
            Console.WriteLine("You can close the console now");
            Console.ReadLine();

        }

        public static void GetJobHttpInfo(string jobString)
        {

            try
            {
                if (string.IsNullOrEmpty(jobString))
                    throw new ArgumentException("Invalid Job ID");
                LogSetup.OneTimeSetup("logs.DemoApp.txt");

                var me = Helper.CurrentUser;
                Logger.Info($"You are: {me.Username}");

                var texts = jobString.Split('/').Select(_ => _.Trim()).Where(_ => !string.IsNullOrEmpty(_)).ToList();

                var projOwner = texts[0];
                var projName = texts[1];
                var jobID = texts[2];
                Console.WriteLine($"=> Project Owner: {projOwner}");
                Console.WriteLine($"=> Project Name: {projName}");
                Console.WriteLine($"=> Job ID: {jobID}");
                Console.WriteLine($"Log path: {LogSetup.GetTheLatestLog()}");

                Logger.Info($"DemoApp: getting project [{projOwner}/{projName}].");
                var projApi = new PollinationSDK.Api.ProjectsApi();
                var proj = projApi.GetProject(projOwner, projName);
                Logger.Info($"DemoApp: got the project [{proj.Owner.Name}/{proj.Name}].");
                Logger.Info($"DemoApp: Got the Project: {Environment.NewLine}{proj.ToJson()}");
                Console.WriteLine($"DemoApp: got the project [{proj.Owner.Name}/{proj.Name}].");

                Logger.Info($"DemoApp: getting job [{proj.Owner.Name}/{proj.Name}/{jobID}].");
                var api = new PollinationSDK.Api.JobsApi();
                var jobHttp = api.GetJobWithHttpInfo(proj.Owner.Name, proj.Name, jobID.ToString());
                Logger.Info($"DemoApp: got job with HTTP info:");

                Logger.Info($"API Response StatusCode: {jobHttp?.StatusCode}.");
                Console.WriteLine($"API Response StatusCode: {jobHttp?.StatusCode}.");
                var headers = jobHttp.Headers.Select(_ => $"{_.Key}:{_.Value}");
                foreach (var item in headers)
                {
                    var msg = $"API Response Header: {item}.";
                    Logger.Info(msg);
                    Console.WriteLine(msg);
                }

                Logger.Info($"API Response Data: {jobHttp?.Data?.ToJson()}.");
                Console.WriteLine($"API Response Data: {jobHttp?.Data?.ToJson()}.");

            }
            catch (Exception e)
            {
                Logger.Error(e);
                Console.WriteLine($"Check the log file for the error.");
            }

        }

        public static void DownloadBigAssetTest()
        {
            var owner = "studio-greenaarch";
            var projName = "puri-market-complex";
            var instance = new ProjectsApi();
            var proj = instance.GetProject(owner, projName);


            var runApi = new RunsApi();
            // energy simu
            var runId = "4a16380d-0eae-59ea-bf03-871cb4163b7b";
            var run = runApi.GetRun(owner, projName, runId);
            var runInfo = new RunInfo(proj, run);


            var assets = runInfo.GetOutputAssets("grasshopper").OfType<RunAssetBase>().ToList();

            var task = runInfo.DownloadRunAssetsAsync(assets, useCached: false, reportingAction: (s) => Console.WriteLine(s));
            var downloaded = task.Result;


            foreach (var savedAsset in downloaded)
            {
                var item = savedAsset;

                if (item.IsPathAsset())
                {
                    Console.WriteLine($"Is Saved {item.Name}:{item.IsSaved()} to {item.LocalPath}");
                }
                else
                {
                    var v = string.Join(",", item.Value);
                    Console.WriteLine($"Value {item.Name}: {v}");
                }
            }

        }

        private static void ScheduleNewJob(Project proj)
        {
            var cts = new System.Threading.CancellationTokenSource();
            var token = cts.Token;

            var jobInfo = CreateJob_DaylightFactor();
            //var jobInfo = CreateJob_AnnualDaylight();
            try
            {
                jobInfo.SetJobSubFolderPath("round1/test");
                jobInfo.SetJobName("A new daylight simulation");

                // run a job
                jobInfo.SetCloudJob(proj.Owner.Name, proj.Name);
                var task = jobInfo.RunJobAsync((s) => Console.WriteLine(s), token);

                //cts.CancelAfter(60000);
                var scheduledJob = task.Result;

                // watch status
                var watchTask = scheduledJob.WatchJobStatusAsync((s) => Console.WriteLine(s), token);
                watchTask.Wait();
                Console.WriteLine($"Canceled check: {token.IsCancellationRequested}");
                cts.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
                //throw;
            }
        }

        private static async Task<ScheduledJobInfo> runSimu(Project proj, JobInfo job, Action<string> msgAction, CancellationToken token)
        {
            try
            {
                job.SetCloudJob(proj.Owner.Name, proj.Name);
                var scheduledJobInfo = await job.RunJobAsync(msgAction, token);
                msgAction($"Starting the job: {scheduledJobInfo.JobID}");
                //await scheduledJobInfo.WatchRunStatusAsync(msgAction, token);

                //msgAction(runInfo.Logs);

                if (!token.IsCancellationRequested)
                {
                    msgAction($"Finished the job: {scheduledJobInfo.JobID}");
                }

                msgAction($"Canceled by user: {token.IsCancellationRequested}");
                return scheduledJobInfo;

            }
            catch (Exception e)
            {

                throw e;
            }
           

        }

        private static IEnumerable<string> GetRecipes()
        {
            var api = new RecipesApi();
            var d = api.ListRecipes(_public: true);
            var recipes = d.Resources.Select(_ => _.Name);

            return recipes;
        }

        private static void GetRecipeParameters()
        {
            var api = new RecipesApi();
            //var d = api.ListRecipes(owner: new[] { "ladybug-tools" }.ToList()).Resources.First(_ => _.Name == "annual-energy-use");

            var rec = api.GetRecipeByTag("ladybug-tools", "annual-energy-use", "*").Manifest;
            //var recTag = api.GetRecipeByTag("ladybug-tools", "annual-energy-use", "c2657adb0b13db6cd3ff706d9d6db59b98ef8f994d2809d23c3ed449c19b52ea");
       
            var inputs = rec.Inputs.OfType<GenericInput>();
            var ParamNames = inputs.Select(_ => _.Name);
            Console.WriteLine("------------------Getting Recipe Input Params---------------------");
            Console.WriteLine(string.Join("\n", ParamNames));

        }

        private static JobInfo CreateJob_AnnualDaylight()
        {
            var recipeOwner = "ladybug-tools";
            var recipeName = "annual-daylight";
            var recipeApi = new RecipesApi();
            var rec = recipeApi.GetRecipeByTag(recipeOwner, recipeName, "latest").Manifest;

            var jobInfo = new JobInfo(rec);

            //job.AddArgument(new JobArgument("sensor-grids", "[\"room\"]"));
            jobInfo.AddArgument(new JobPathArgument("model", new ProjectFolder(path: @"D:\Test\queenbeeTest\two_rooms.hbjson")));
            jobInfo.AddArgument(new JobPathArgument("wea", new ProjectFolder(path: @"D:\Test\queenbeeTest\golden_co.wea")));

            return jobInfo;

        }

        private static JobInfo CreateJob_DaylightFactor()
        {
          

            var recipeOwner = "ladybug-tools";
            var recipeName = "daylight-factor";
            var recipeApi = new RecipesApi();
            var rec = recipeApi.GetRecipeByTag(recipeOwner, recipeName, "latest").Manifest;

            var jobInfo = new JobInfo(rec);

            jobInfo.AddArgument(new JobPathArgument("model", new ProjectFolder(path: @"D:\Test\queenbeeTest\model.hbjson")));
            //job.AddArgument(new JobPathArgument("input", new ProjectFolder(path: @"D:\Test\queenbeeTest\inputs.json")));


            return jobInfo;

        }



        private static ProjectList GetProjects(UserPrivate user)
        {
            var api = new ProjectsApi();
            var d = api.ListProjects(_public: true, owner: new List<string>() { user.Username });
            //var projectNames = d.Select(_ => $"<{_.Id}> {_.Name} ({_.Owner.Name})");

            return d;
        }

        private static Project CreateAProject(UserPrivate user)
        {
            var userName = user.Username;
            //var userName = "mingbo";

            var api = new ProjectsApi();

            var name = "My new project " + Guid.NewGuid().ToString().Substring(0, 5);
            var proj = new ProjectCreate(name, "A new project from GH");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Creating project: {name}");
            var res = api.CreateProject(userName, proj);

            Console.WriteLine($"New project id: {res.Id}");
            Console.WriteLine(res.Message);

            var newProj = Helper.GetAProject(user.Username, name);
            return newProj;
        }

        private static void DeleteMyProjects(UserPrivate user, string projectName)
        {
            var userName = user.Username;
            var api = new ProjectsApi();
            api.DeleteProject(userName, projectName);

        }

    

        private static void CheckOutputLogs(Project proj, string simuId)
        {
            var api = new RunsApi();
      
            var steps = api.GetRunSteps(proj.Owner.Name, proj.Name, simuId.ToString());
            foreach (var item in steps.Resources)
            {
                var stepLog = api.GetRunStepLogs(proj.Owner.Name, proj.Name, simuId.ToString(), item.Id);
                Console.WriteLine(stepLog);
            }
           
        }

        private static void DownloadAssets(Project proj)
        {

            var runApi = new PollinationSDK.Api.RunsApi();

            var firstRun = runApi.ListRuns(proj.Owner.Name, proj.Name, page: 1, perPage: 1).Resources.First();
            var runInfo = new RunInfo(proj, firstRun);

            // get all output assets to download

            var assets = runInfo.GetOutputAssets("grasshopper").OfType<RunAssetBase>().ToList();
            var inputAssets = runInfo.GetInputAssets();
            assets = assets.Concat(inputAssets).ToList();

            var savedPath = System.IO.Path.GetTempPath();
            var task = Task.Run(async () => await DownloadAsync(runInfo, assets, savedPath));
            var filePaths = task.GetAwaiter().GetResult();

            foreach (var item in filePaths)
            {
                Console.WriteLine($"Asset: {item.Name}\nSaved Path: {item.LocalPath}");
            }

        }

        private static async Task<List<RunAssetBase>> DownloadAsync(RunInfo runInfo, List<RunAssetBase> outputAssets, string saveAsDir = default)
        {

            // progress reporter
            Action<string> UpdateProgressMessage = (s) => Console.WriteLine(s);

            // if use cached data
            var useCachedAssets = false;

            // download all assets
            var task = runInfo.DownloadRunAssetsAsync(outputAssets, saveAsDir, UpdateProgressMessage, useCachedAssets);
            var filePaths = await task;

            //await Task.Delay(3000);
            if (task.IsFaulted && task.Exception != null)
                throw task.Exception;

            return filePaths;
            

        }

    }


}
