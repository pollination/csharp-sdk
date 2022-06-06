using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace PollinationSDK.Wrapper
{
    public class JobInfo
    {
        public string RecipeOwner { get; set; }
        public RecipeInterface Recipe { get; set; }
        public Job Job { get; set; }
        public string SubFolderPath { get; set; }
        public bool IsLocalJob { get; set; }
        public string CloudProject { get; set; } // for cloud job only
        public int LocalCPUNumber { get; set; } // for local job only
        public string LocalRunFolder { get; set; } // for local job only

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


        public void SetLocalJob(string runFolder, int cpuNo)
        {
            this.IsLocalJob = true;
            this.LocalRunFolder = runFolder;
            this.LocalCPUNumber = cpuNo;
        }

        public void SetCloudJob(string projectOwner, string projectName)
        {
            this.IsLocalJob = false;
            this.CloudProject = $"{projectOwner}/{projectName}";
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
        private List<AnyOf<JobArgument, JobPathArgument>> CheckArgumentsWithHandlers(List<AnyOf<JobArgument, JobPathArgument>> args, string platform, string handlerLanguage)
        {
            //Deal with single run
            var inputs = this.Recipe.InputList;
            var handlerChecker = DefaultHandlerChecker.Instance;

            // create a placeholder
            var job = new Job("invalid");

            foreach (var item in inputs)
            {
                var isPath = item.IsPathType();
                PollinationSDK.Interface.Io.Inputs.IJob currentArg = null;
                if (isPath)
                    currentArg = args.OfType<JobPathArgument>().FirstOrDefault(_ => _.Name == item.Name);
                else
                    currentArg = args.OfType<JobArgument>().FirstOrDefault(_ => _.Name == item.Name);

                var dagInputAlias = item.GetAlias(platform);
                if (dagInputAlias == null) // do nothing is there is no alias
                {
                    job.AddArgument(currentArg);
                    continue;
                }
                
                var linkedAlias = dagInputAlias as PollinationSDK.DAGLinkedInputAlias;
                object processedData = null;
                if (linkedAlias?.Handler != null) // linked input
                {
                    var handler = linkedAlias.Handler.FirstOrDefault(_ => _.Language == handlerLanguage);
                    processedData = handlerChecker.CheckLinkedData(handler)?.ToString();
                }
                else // other alias
                {
                    if (isPath)
                    {
                        var a = currentArg as JobPathArgument;
                        processedData = handlerChecker.CheckWithHandlers(a.Source, dagInputAlias.Handler);
                    }
                    else
                    {
                        var a = currentArg as JobArgument;
                        processedData = handlerChecker.CheckWithHandlers(a.Value, dagInputAlias.Handler);
                    }
                }

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

        public void CheckArgumentsWithHandlers(string platform, string handlerLanguage)
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
                var set = CheckArgumentsWithHandlers(argSet, platform, handlerLanguage);
                newArgSets.Add(set);
            }

            this.Job.Arguments = newArgSets;
        }



        public static void RunJob(string jobInfoJson)
        {
            var job = JobInfo.FromJson(jobInfoJson);
            if (job.IsLocalJob)
            {
                job.RunJobOnLocal();
            }
            else
            {
                job.RunJobOnCloud();
            }
        }

        public RunInfo RunJobOnLocal()
        {
            if (string.IsNullOrEmpty(this.LocalRunFolder) || !this.IsLocalJob)
                throw new ArgumentException($"Please call SetLocalJob() before running a job");
            var workDir = this.LocalRunFolder;
            var cpuNum = this.LocalCPUNumber;
            var runner = new JobRunner(this);
            var projPath = runner.RunOnLocalMachine(workDir, cpuNum);
            return new RunInfo(Recipe, projPath);
        }

        public async Task<ScheduledJobInfo> RunJobOnCloud(Action<string> progressReporting = default, System.Threading.CancellationToken token = default)
        {
            if (string.IsNullOrEmpty(this.CloudProject) || this.IsLocalJob)
                throw new ArgumentException($"Please call SetCloudJob() before running a job");

            var proj = GetWritableProject();
            var runner = new JobRunner(this);
            var cloudJob =  await runner.RunOnCloudAsync(proj, progressReporting, token);
            return new ScheduledJobInfo(proj, cloudJob);
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
            var proj = this.CloudProject;
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
