using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;

namespace PollinationSDK.Wrapper
{
    public class JobInfo
    {
        public AccountPublic JobAuthor { get; set; }
        public string RecipeOwner { get; set; }
        public RecipeInterface Recipe { get; set; }
        public Job Job { get; set; }
        public string SubFolderPath { get; set; }
        public bool IsLocalJob { get; set; }
        public string ProjectSlug { get; set; } // for cloud and local job, ladybug_tools/demoProject
        public int LocalCPUNumber { get; set; } // for local job only
        public string LocalRunFolder { get; set; } // for local job only
        public bool LocalSilentMode { get; set; } // for local job only
        public string Platform { get; set; } = "unknown"; // rhino, revit, grasshopper
        public string LocalJobStatus { get; set; } = "unknown"; // RunStatusEnum for a local job

        [IgnoreDataMember]
        public string LocalRunOutputFolder => GetLocalRunDir(this.LocalRunFolder, Job);

        [JsonConstructorAttribute]
        protected JobInfo() { }

        public JobInfo(RecipeInterface recpie)
        {
            this.Recipe = recpie;
            //recpie.Source: https://api.staging.pollination.cloud/registries/ladybug-tools/recipe/annual-daylight/0.6.4
          
            this.RecipeOwner = GetRecipeOwnerFromSourceURL(recpie.Source);
            this.Job = new Job(recpie.Source);
            this.Job.Arguments = new List<List<AnyOf<JobArgument, JobPathArgument>>>();
        }

        public JobInfo(Job job)
        {
           //recpie.Source: https://api.staging.pollination.cloud/registries/ladybug-tools/recipe/annual-daylight/0.6.4
           var reciptSource = job.Source;
           this.RecipeOwner = GetRecipeOwnerFromSourceURL(reciptSource);
           this.Recipe = GetRecipe(reciptSource);
           this.Job = job;
           this.Job.Arguments = new List<List<AnyOf<JobArgument, JobPathArgument>>>();
        }


        public void SetLocalJob(string projectOwner, string projectName, string runFolder, int cpuNo)
        {
            this.IsLocalJob = true;
            this.ProjectSlug = $"{projectOwner}/{projectName}".ToLower();
            this.LocalRunFolder = runFolder;
            this.LocalCPUNumber = cpuNo;
        }

        public void SetLocalSilentMode(bool enableSilent)
        {
            if (this.IsLocalJob) 
                this.LocalSilentMode = enableSilent;
            else
                throw new ArgumentException("Silent mode only works with local job! Call SetLocalJob() to set local job settings first!");

        }

        public void SetJobAuthor(AccountPublic authorAccount)
        {
            this.JobAuthor = authorAccount;
        }

        public void SetCloudJob(string projectOwner, string projectName)
        {
            this.IsLocalJob = false;
            this.ProjectSlug =   $"{projectOwner}/{projectName}".ToLower();
        }

        public void SetPlatform(string platform)
        {
            this.Platform = platform;
        }

        private static string GetRecipeOwnerFromSourceURL(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Failed to find the source of recipe!");
            //recpie.Source: https://api.staging.pollination.cloud/registries/ladybug-tools/recipe/annual-daylight/0.6.4
            var recipeOwner = url.Split('/')?.Reverse()?.Take(4)?.LastOrDefault();
            return recipeOwner;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, JsonSetting.AnyOfConvertSetting);
        }

        public static JobInfo FromJson(string json)
        {
            var obj =  JsonConvert.DeserializeObject<JobInfo>(json, JsonSetting.AnyOfConvertSetting);
            return obj;
        }

        public JobInfo Duplicate()
        {
            return FromJson(this.ToJson());
        }

        private List<AnyOf<JobArgument, JobPathArgument>> CheckArgumentsWithHandlers(List<AnyOf<JobArgument, JobPathArgument>> args, string platform, HandlerChecker handlerChecker)
        {
            //Deal with single run
            var inputs = this.Recipe.InputList;
           
            // create a placeholder
            var job = new Job("invalid");

            foreach (var item in inputs)
            {
                var isPath = item.IsPathType();
                PollinationSDK.Interface.Io.Inputs.IJob currentArg = null;
                object currentValue = null;
                if (isPath)
                {
                    var pathArg = args.OfType<JobPathArgument>().FirstOrDefault(_ => _.Name == item.Name);
                    
                    // only validate if a path is ProjectFolder type, there is no way to validate HTTPS or S3 link
                    if (pathArg?.Source?.Obj is ProjectFolder pf)
                    {
                        currentArg = pathArg;
                        currentValue = pf.Path;
                    }
                }
                else
                {
                    var valueArg = args.OfType<JobArgument>().FirstOrDefault(_ => _.Name == item.Name);
                    currentArg = valueArg;
                    currentValue = valueArg?.Value;
                }

                if (currentArg == null)
                    continue;


                var processedData = InputArgumentValidator.CheckAndValidate(item, platform, currentValue, handlerChecker);
                if (processedData == null)
                {
                    job.AddArgument(currentArg);
                }
                else
                { 
                    // override the existing argument
                    if (isPath)
                        job.AddArgument(new JobPathArgument(item.Name, new ProjectFolder(path: processedData?.ToString())));
                    else
                        job.AddArgument(new JobArgument(item.Name, value: processedData));
                }


            }

            // placeholder job only has one set of arguments
            return job.Arguments.LastOrDefault();

        }

        public void CheckArgumentsWithHandlers(string platform)
        {
            CheckArgumentsWithHandlers(platform, DefaultHandlerChecker.Instance);
        }

        public void CheckArgumentsWithHandlers(string platform, HandlerChecker handlerChecker)
        {
            if(this.Recipe == null)
            {
                this.RecipeOwner = GetRecipeOwnerFromSourceURL(this.Job.Source);
                this.Recipe = GetRecipe(this.Job.Source);
            }

            if(this.Job == null)
            {
                this.Job = new Job(this.Recipe.Source);
            }

            var argSets = this.Job.Arguments;
            var newArgSets = new List<List<AnyOf<JobArgument, JobPathArgument>>>();
            foreach (var argSet in argSets)
            {
                var set = CheckArgumentsWithHandlers(argSet, platform, handlerChecker);
                newArgSets.Add(set);
            }

            this.Job.Arguments = newArgSets;
        }

        private static string GetLocalRunDir(string root, Job job)
        {
            var workName = job.Name ?? "Unnamed";
            workName = new String(workName.Where(c => char.IsLetterOrDigit(c)).ToArray());

            var workDir = Path.Combine(root, workName);
            if (!Directory.Exists(workDir))
                Directory.CreateDirectory(workDir);

            return workDir;
        }

        //public static void RunJob(string jobInfoJson)
        //{
        //    var job = JobInfo.FromJson(jobInfoJson);
        //    job.RunJob();
        //}

        public ScheduledJobInfo RunJob()
        {
            var job = this;
            ScheduledJobInfo jobInfo = null;
            if (job.IsLocalJob)
            {
                jobInfo = job.RunJobOnLocalAsync().GetAwaiter().GetResult();
            }
            else
            {
                jobInfo = job.RunJobOnCloudAsync().GetAwaiter().GetResult();
            }

            return jobInfo;
        }

        public async Task<ScheduledJobInfo> RunJobAsync(Action<string> progressReporting = default, System.Threading.CancellationToken token = default)
        {
            var job = this;
            ScheduledJobInfo jobInfo = null;
            if (job.IsLocalJob)
            {
                jobInfo = await job.RunJobOnLocalAsync();
            }
            else
            {
                jobInfo = await job.RunJobOnCloudAsync(progressReporting, token);
            }

            return jobInfo;
        }

      

        private async Task<ScheduledJobInfo> RunJobOnLocalAsync()
        {
            if (string.IsNullOrEmpty(this.LocalRunFolder) || !this.IsLocalJob)
                throw new ArgumentException($"Please call SetLocalJob() before running a job");

            var workDir = this.LocalRunOutputFolder;
            var cpuNum = this.LocalCPUNumber;
            var isSilentMode = this.LocalSilentMode;
            var runner = new JobRunner(this);
            var runout = await Task.Run(() => runner.RunOnLocalMachine(workDir, cpuNum, isSilentMode)).ConfigureAwait(false);
            // check local job status
            var status = JobRunner.CheckLocalJobStatus(runout);
            this.LocalJobStatus = status.ToString();

            var jobInfo = new ScheduledJobInfo(this, workDir);

            //save jobinfo to folder
            var jobPath = Path.Combine(jobInfo.SavedLocalPath, "job.json");
            File.WriteAllText(jobPath, jobInfo.ToJson());

            // add the record to local database
            LocalDatabase.Instance.Add(jobInfo);
            return jobInfo;
        }

        private async Task<ScheduledJobInfo> RunJobOnCloudAsync(Action<string> progressReporting = default, System.Threading.CancellationToken token = default)
        {
            if (string.IsNullOrEmpty(this.ProjectSlug) || this.IsLocalJob)
                throw new ArgumentException($"Please call SetCloudJob() before running a job");

            var proj = GetWritableProject();
            var runner = new JobRunner(this);
            var cloudJob =  await runner.RunOnCloudAsync(proj, progressReporting, token);
            var jobInfo =  new ScheduledJobInfo(proj, cloudJob);

            // add the record to local database
            //LocalDatabase.Instance.Add(jobInfo);
            return jobInfo;
        }

        public async Task<Job> UploadJobAssetsAsync(Action<string> progressReporting = default, System.Threading.CancellationToken token = default)
        {
            if (string.IsNullOrEmpty(this.ProjectSlug) || this.IsLocalJob)
                throw new ArgumentException($"Please call SetCloudJob() before running a job");

            var proj = GetWritableProject();
            var runner = new JobRunner(this);
            var newJob = await JobRunner.UploadJobAssetsAsync(proj, this.Job, this.SubFolderPath, progressReporting, token);
  
            return newJob;
        }


        public void AddArgument(JobArgument arg) => this.Job.AddArgument(arg);
        public void AddArgument(JobPathArgument arg) => this.Job.AddArgument(arg);

        public void SetJobName(string name)
        {
            if (string.IsNullOrEmpty(name)) return;
            this.Job.Name = name;
        }

        public void SetJobSubFolderPath(string path)
        {
            if (string.IsNullOrEmpty(path)) return;
            path = path.Replace('\\', '/').Replace(' ', '_');
            this.SubFolderPath = path;
        }

        public void SetJobKeywords(List<string> keywords)
        {
            if (keywords == null) return;
            this.Job.Labels = new Dictionary<string, string>() { { "keywords", string.Join(",", keywords) } };
        }
        public void SetJobDescription(string description)
        {
            this.Job.Description = description;
        }

        private static RecipeInterface GetRecipe(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Failed to find the source of recipe!");
            //recpie.Source: https://api.staging.pollination.cloud/registries/ladybug-tools/recipe/annual-daylight/0.6.4
            var args = url.Split('/')?.Reverse()?.Take(4);
            var recipeOwner = args?.LastOrDefault();
            var version = args?.FirstOrDefault();
            var recipeName = args?.Skip(1).FirstOrDefault();
            return GetRecipe(recipeOwner, recipeName, version);

        }

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

        private Project GetWritableProject()
        {
            // ladybug_tools/demoProject
            var proj = this.ProjectSlug;
            var args = proj.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            if (args.Count != 2)
                throw new ArgumentException($"Failed to get a valid project from [{proj}]");
            var projOwner = args.FirstOrDefault();
            var projName = args.LastOrDefault();

            var p = Helper.GetAProject(projOwner, projName);
            if (!p.Permissions.Write)
                throw new ArgumentException($"You don't have access to [{p.Slug}] project. Switch to a different project using the SetupRuns component.");
          
            return p;
        }
    }
}
