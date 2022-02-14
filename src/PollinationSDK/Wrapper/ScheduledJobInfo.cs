﻿using PollinationSDK.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollinationSDK.Wrapper
{
    public class ScheduledJobInfo
    {
        public string JobID => IsLocalJob? this.LocalJob.RunID : this.CloudJob.Id;
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
        }

        public ScheduledJobInfo(RunInfo localRun)
        {
            this.LocalJob = localRun;
            this.Recipe = localRun.Recipe;
        }

        public ScheduledJobInfo(string clouldProjectName, string projectOwner, string jobID)
        {
            var projApi = new ProjectsApi();
            this.Project = projApi.GetProject(projectOwner, clouldProjectName);
            this.CloudJob = GetJob(this.Project, jobID);
            this.Recipe = this.CloudJob.Recipe;
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
            var api = new JobsApi();
            var proj = this.Project;
            var jobId = this.JobID;

            var cloudJob = api.GetJob(proj.Owner.Name, proj.Name, jobId);
            var status = cloudJob.Status;
            var startTime = status.StartedAt;
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
                    var message = total > 1 ? $"{status.Status}: [{done}/{total}]\n{timer}": $"{status.Status}: [{timer}]";
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
            this.CloudJob = cloudJob;
            // suspended by user
            cancelToken.ThrowIfCancellationRequested();

            var totalTime = status.FinishedAt - startTime;
            var finishMessage = status.Status.ToString();
            //progressAction?.Invoke($"Task: {status.Status}");

            finishMessage = $"{finishMessage}: [{GetUserFriendlyTimeCounter(totalTime)}]";
            progressAction?.Invoke(finishMessage);
            return finishMessage;

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
        }

        private Dictionary<int, RunInfo> _runInfoCache = new Dictionary<int, RunInfo>();

        public RunInfo GetRunInfo(int runIndex)
        {
            if (_runInfoCache.ContainsKey(runIndex))
                return _runInfoCache[runIndex];

            var jobInfo = this;
            // only get the first run asset for now
            var job = jobInfo.CloudJob;

            //check run index if valid
            var page = runIndex + 1;
            var totalRuns = job.Status.RunsCompleted + job.Status.RunsFailed + job.Status.RunsPending + job.Status.RunsRunning;
            if (totalRuns == 0)
                throw new ArgumentException($"[Error] Job status: [{job.Status.Status}]. There is no run available in this job");

            if (page > totalRuns)
                throw new ArgumentException($"[Error] This job has {totalRuns} runs in total, a valid run index could from 0 to { totalRuns - 1};");

            var api = new PollinationSDK.Api.RunsApi();
            var runs = api.ListRuns(jobInfo.Project.Owner.Name, jobInfo.Project.Name, jobId: new List<string>() { job.Id }, page: page, perPage: 1).Resources;
            var firstRun = runs.FirstOrDefault();

            var isRunFinished = firstRun.Status.FinishedAt > firstRun.Status.StartedAt;
            if (!isRunFinished)
                throw new ArgumentException($"[Warning] Run status: {firstRun.Status.Status}. If this run [{firstRun.Id.Substring(0, 5)}] is scheduled but not finished, please check it again in a few seconds;");
           
            var runInfo = new RunInfo(jobInfo.Project, firstRun);

            _runInfoCache.Add(runIndex, runInfo);
            return runInfo;
        }

    }
}
