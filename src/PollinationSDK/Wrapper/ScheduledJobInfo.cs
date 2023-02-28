using PollinationSDK.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollinationSDK.Wrapper
{
    public class ScheduledJobInfo
    {
        public Guid LocalJobID { get; private set; }
        public string JobID => IsLocalJob? this.LocalJobID.ToString() : this.CloudJob.Id;
        public CloudJob CloudJob { get; private set; }
        public Project Project { get; private set; }
        public RecipeInterface Recipe { get; private set; }
        public RunInfo LocalJob { get; private set; }
        public bool IsLocalJob => LocalJob != null;
        //[IgnoreDataMember]
        //public string Logs { get; set; }
        public ScheduledJobInfo(Project proj, string jobID): this(proj, GetJob(proj, jobID))
        {
        }

        public ScheduledJobInfo(Project proj, CloudJob run)
        {
            this.CloudJob = run;
            this.Project = proj;
            this.Recipe = this.CloudJob.Recipe;
            this.LocalJobID = Guid.Empty;
        }

        public ScheduledJobInfo(RunInfo localRun)
        {
            this.LocalJob = localRun;
            this.Recipe = localRun.Recipe;
            this.LocalJobID = Guid.NewGuid();
        }

        public ScheduledJobInfo(string clouldProjectName, string projectOwner, string jobID)
        {
            var projApi = new ProjectsApi();
            this.Project = projApi.GetProject(projectOwner, clouldProjectName);
            this.CloudJob = GetJob(this.Project, jobID);
            this.Recipe = this.CloudJob.Recipe;
            this.LocalJobID = Guid.Empty;
        }

        private static CloudJob GetJob(Project proj, string jobID)
        {
            var api = new JobsApi();
            var job = api.GetJob(proj.Owner.Name, proj.Name, jobID.ToString());
            return job;
        }

        //private static RecipeInterface GetRecipe(string url)
        //{
        //    Helper.GetRecipeFromRecipeSourceURL(url, out var recipe);
        //    return recipe;
        //}


        public override string ToString()
        {
            return  this.IsLocalJob ? this.JobID : $"CLOUD:{this.Project.Owner.Name}/{this.Project.Name}/{this.JobID}";
        }
        

        public async Task<string> WatchJobStatusAsync(Action<string> progressAction = default, System.Threading.CancellationToken cancelToken = default)
        {
            try
            {
                var api = new JobsApi();
                //api.ListJobs
                var proj = this.Project;
                var jobId = this.JobID;
                Helper.Logger.Information($"WatchJobStatusAsync: checking job [{proj.Owner.Name}/{proj.Name}/{jobId}].");

                var cloudJob = api.GetJob(proj.Owner.Name, proj.Name, jobId);
                var status = cloudJob.Status;
                var startTime = status.StartedAt;
                Helper.Logger.Information($"WatchJobStatusAsync: init status: {status.ToJson()}");

                while (status.FinishedAt <= status.StartedAt)
                {
                    var currentSeconds = Math.Round((DateTime.UtcNow - startTime).TotalSeconds);
                    // wait 5 seconds before calling api to re-check the status
                    var totalDelaySeconds = status.Status == JobStatusEnum.Created ? 3 : 5;

                    var running = status.RunsPending + status.RunsRunning;
                    var done = status.RunsFailed + status.RunsCompleted + status.RunsCancelled;
                    var total = running + done;

                    for (int i = 0; i < totalDelaySeconds; i++)
                    {
                        // suspended by user
                        cancelToken.ThrowIfCancellationRequested();

                        var timer = GetUserFriendlyTimeCounter(TimeSpan.FromSeconds(currentSeconds));
                        var message = total > 1 ? $"{status.Status}: [{done}/{total}]\n{timer}" : $"{status.Status}: [{timer}]";
                        progressAction?.Invoke(message);

                        await Task.Delay(1000);
                        currentSeconds++;
                    }
                    // suspended by user
                    cancelToken.ThrowIfCancellationRequested();

                    // update status
                    await Task.Delay(1000);
                    cloudJob = api.GetJob(proj.Owner.Name, proj.Name, jobId);
                    status = cloudJob.Status;
                    //_simulation = new Simulation(proj, simuId);
                }

                Helper.Logger.Information($"WatchJobStatusAsync: finished status: {status.ToJson()}");
                this.CloudJob = cloudJob;
                // suspended by user
                cancelToken.ThrowIfCancellationRequested();

                var totalTime = status.FinishedAt - startTime;
                var finishMessage = status.Status.ToString();

                //progressAction?.Invoke($"Task: {status.Status}");

                finishMessage = $"{finishMessage}: [{GetUserFriendlyTimeCounter(totalTime)}]";
                progressAction?.Invoke(finishMessage);
                Helper.Logger.Information($"WatchJobStatusAsync: finished checking job [{proj.Owner.Name}/{proj.Name}/{jobId}]: [{finishMessage}].");

                return finishMessage;
            }
            catch (Exception e)
            {
                Helper.Logger.Error(e, $"WatchJobStatusAsync: failed to watch job [{Project.Owner.Name}/{Project.Name}/{JobID}].");
                throw e;
            }

           

            string GetUserFriendlyTimeCounter(TimeSpan timeDelta)
            {
                string format = @"hh\:mm\:ss";
                if (timeDelta.Days > 0)
                    format = @"d\ hh\:mm\:ss";
                else if (timeDelta.Hours > 0)
                    format = @"hh\:mm\:ss";
                else if (timeDelta.Minutes > 0)
                    format = @"mm\:ss";
                else
                    format = @"ss";
                return timeDelta.ToString(format);
            }
        }

        public void CancelJob()
        {
            var proj = this.Project;
            var api = new JobsApi();
            api.CancelJobAsync(proj.Owner.Name, proj.Name, this.JobID);
            Helper.Logger.Information($"CancelJob: [{proj.Owner.Name}/{proj.Name}/{this.JobID}].");

        }

        private Dictionary<int, RunInfo> _runInfoCache = new Dictionary<int, RunInfo>();

        public RunInfo GetRunInfo(int runIndex)
        {
            if (_runInfoCache.ContainsKey(runIndex))
                return _runInfoCache[runIndex];

            var jobInfo = this;

            if (jobInfo.IsLocalJob)
            {
                return this.LocalJob;
            }
            else
            {
                // only get the first run asset for now
                var job = jobInfo.CloudJob;

                //check run index if valid
                var page = runIndex + 1;
                var jobStatus = job.Status;
                var totalRuns = jobStatus.RunsCompleted + jobStatus.RunsFailed + jobStatus.RunsPending + jobStatus.RunsRunning + jobStatus.RunsCancelled;
                if (totalRuns == 0)
                {
                    var err = new ArgumentException($"[Error] Job status: [{jobStatus.Status}]. There is no run available in this job");
                    Helper.Logger.Error(err, $"GetRunInfo: {jobStatus?.ToJson()}.");
                    throw err;
                }

                if (page > totalRuns)
                {
                    var err = new ArgumentException($"[Error] This job has {totalRuns} runs in total, a valid run index could from 0 to { totalRuns - 1};");
                    Helper.Logger.Error(err, $"GetRunInfo: {jobStatus.ToJson()}.");
                    throw err;
                }

                var api = new PollinationSDK.Api.RunsApi();
                var runs = api.ListRuns(jobInfo.Project.Owner.Name, jobInfo.Project.Name, jobId: new List<string>() { job.Id }, page: page, perPage: 1).Resources;
                var firstRun = runs.FirstOrDefault();

                var isRunFinished = firstRun.Status.FinishedAt > firstRun.Status.StartedAt;
                if (!isRunFinished)
                {
                    var err = new ArgumentException($"[Warning] Run status: {firstRun.Status.Status}. If this run [{firstRun.Id.Substring(0, 5)}] is scheduled but not finished, please check it again in a few seconds;");
                    Helper.Logger.Error(err, $"GetRunInfo: {firstRun?.Status?.ToJson()}.");
                    throw err;
                }

                var runInfo = new RunInfo(jobInfo.Project, firstRun);

                _runInfoCache.Add(runIndex, runInfo);
                return runInfo;
            }
           
        }

    }
}
