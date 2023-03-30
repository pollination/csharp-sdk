﻿using Newtonsoft.Json;
using PollinationSDK.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PollinationSDK.Wrapper
{
    /// <summary>
    /// This is used for watching the running status of a job that has been scheduled/executed.
    /// </summary>
    public class ScheduledJobInfo
    {
        public string JobID { get; set; }
        public CloudJob CloudJob { get; set; }
        public Project CloudProject { get; set; }
        
        public JobInfo LocalJob { get; set; }
        public string SavedLocalPath { get; set; }

        public string Platform { get; set; } = "unknown"; // rhino, revit, grasshopper

        [IgnoreDataMember]
        public bool IsLocalJob => LocalJob != null;
        [IgnoreDataMember]
        public string JobSlug => $"{ProjectSlug}/{JobID}";
        [IgnoreDataMember]
        public string ProjectSlug => IsLocalJob ? this.LocalJob.ProjectSlug : CloudProject.Slug;
        [IgnoreDataMember]
        public RecipeInterface Recipe => IsLocalJob ? this.LocalJob.Recipe : CloudJob.Recipe;

        [IgnoreDataMember]
        public string JobStatus => IsLocalJob ? this.LocalJob.LocalJobStatus : CloudJob?.Status?.Status.ToString(); // RunStatusEnum for a local job and JobStausEnum for a cloud job

        [JsonConstructorAttribute]
        protected ScheduledJobInfo() { }

        public ScheduledJobInfo(Project proj, CloudJob cloudJob)
        {
            this.CloudJob = cloudJob; 
            this.LocalJob = null;

            this.CloudProject = proj;
            this.JobID = this.CloudJob.Id;
            this.SavedLocalPath = Path.Combine(Path.GetTempPath(), "Pollination", this.JobID.Substring(0, 8));
        }

        public ScheduledJobInfo(JobInfo localJob, string localDir)
        {
            this.LocalJob = localJob;
            this.CloudJob = null;

            //this.LocalProject = localJob.Project;
            //this.Recipe = localJob.Recipe;
            this.JobID = Guid.NewGuid().ToString();
            this.SavedLocalPath = string.IsNullOrEmpty(localDir) 
                ? Path.Combine(Path.GetTempPath(), "Pollination", this.JobID.Substring(0, 8)) 
                : localDir;

            this.Platform = localJob.Platform;
        }

        public static ScheduledJobInfo From(Project proj, string jobID)
        {
            var schJob = new ScheduledJobInfo(proj, GetJob(proj, jobID));
            return schJob;
        }

        public static ScheduledJobInfo From(string projectOwner, string projectName, string jobID)
        {
            var projApi = new ProjectsApi();
            var proj = projApi.GetProject(projectOwner, projectName);
            var job = GetJob(proj, jobID);
            var schJob = new ScheduledJobInfo(proj, job);
            return schJob;
        }

        /// <summary>
        /// Load from a local run's folder.
        /// This folder must contains job.json for JobInfo
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public static ScheduledJobInfo From(string runFolder)
        {
            if (!Directory.Exists(runFolder))
                throw new System.ArgumentException($"Invalid run folder {runFolder}");
            var jobJson = Path.Combine(runFolder, "job.json");
            if (!File.Exists(jobJson))
                throw new System.ArgumentException($"{runFolder} doesn't have a job.json file!");

            var job = ScheduledJobInfo.FromJson(File.ReadAllText(jobJson));
            return job;
        }


        private static CloudJob GetJob(Project proj, string jobID)
        {
            var api = new JobsApi();
            var job = api.GetJob(proj.Owner.Name, proj.Name, jobID.ToString());
            return job;
        }

        public void SyncCloudJob()
        {
            if (this.IsLocalJob)
                throw new ArgumentException("This is not a cloud job");
            this.CloudJob = GetJob(this.CloudProject, this.JobID);
        }

        //private static RecipeInterface GetRecipe(string url)
        //{
        //    Helper.GetRecipeFromRecipeSourceURL(url, out var recipe);
        //    return recipe;
        //}


        public override string ToString()
        {
            return  this.IsLocalJob ? $"LOCAL:{this.JobSlug}@{this.SavedLocalPath}" : $"CLOUD:{this.JobSlug}";
        }
        

        public async Task<string> WatchJobStatusAsync(Action<string> progressAction = default, System.Threading.CancellationToken cancelToken = default)
        {
            try
            {
                var api = new JobsApi();
                //api.ListJobs
                var proj = this.CloudProject;
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
                Helper.Logger.Error(e, $"WatchJobStatusAsync: failed to watch job [{CloudProject.Owner.Name}/{CloudProject.Name}/{JobID}].");
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
            var proj = this.CloudProject;
            var api = new JobsApi();
            api.CancelJobAsync(proj.Owner.Name, proj.Name, this.JobID);
            Helper.Logger.Information($"CancelJob: [{proj.Owner.Name}/{proj.Name}/{this.JobID}].");

        }

        private Dictionary<int, RunInfo> _runInfoCache = new Dictionary<int, RunInfo>();

        public RunInfo GetRunInfo(int runIndex)
        {
            if (_runInfoCache.ContainsKey(runIndex))
                return _runInfoCache[runIndex];

            var schJobInfo = this;

            if (schJobInfo.IsLocalJob)
            {
                if (schJobInfo.LocalJob.LocalJobStatus != RunStatusEnum.Succeeded.ToString())
                    throw new ArgumentException($"Failed to load a local job [{schJobInfo.SavedLocalPath}]. Job status is [{schJobInfo.LocalJob.LocalJobStatus}]");

                var runInfo = new RunInfo(schJobInfo);
                return runInfo;
            }
            else
            {
                // only get the first run asset for now
                var job = schJobInfo.CloudJob;

                //check run index if valid
                var page = runIndex + 1;
                var jobStatus = job.Status;
                if (jobStatus.FinishedAt <= jobStatus.StartedAt)
                {
                    // unfinished job, try to update the cloud job from server
                    schJobInfo.SyncCloudJob();
                    job = schJobInfo.CloudJob;
                    jobStatus = job.Status;
                }
                        
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
                var runs = api.ListRuns(schJobInfo.CloudProject.Owner.Name, schJobInfo.CloudProject.Name, jobId: new List<string>() { job.Id }, page: page, perPage: 1).Resources;
                var firstRun = runs.FirstOrDefault();

                var isRunFinished = firstRun.Status.FinishedAt > firstRun.Status.StartedAt;
                if (!isRunFinished)
                {
                    var err = new ArgumentException($"[Warning] Run status: {firstRun.Status.Status}. If this run [{firstRun.Id.Substring(0, 5)}] is scheduled but not finished, please check it again in a few seconds;");
                    Helper.Logger.Error(err, $"GetRunInfo: {firstRun?.Status?.ToJson()}.");
                    throw err;
                }

                var runInfo = new RunInfo(schJobInfo.CloudProject, firstRun);

                _runInfoCache.Add(runIndex, runInfo);
                return runInfo;
            }
           
        }


        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, JsonSetting.AnyOfConvertSetting);
        }
        public static ScheduledJobInfo FromJson(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ScheduledJobInfo>(json, JsonSetting.AnyOfConvertSetting);
        }

        public static List<ScheduledJobInfo> FromJsonArray(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ScheduledJobInfo>>(json, JsonSetting.AnyOfConvertSetting);
        }

        public byte[] Serialize_Binary()
        {
            byte[] result = null;

            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                    var json = this.ToJson();
                    binaryWriter.Write(json);
                    binaryWriter.Flush();
                    binaryWriter.Close();
                    result = Compress(memoryStream.ToArray());
                    memoryStream.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            return result;
        }

        public static ScheduledJobInfo Deserialize_Binary(byte[] bytes)
        {
            string json = null;

            try
            {
                var rawBytes = Decompress(bytes);
                using (MemoryStream memoryStream = new MemoryStream(rawBytes))
                {
                    using BinaryReader reader = new BinaryReader(memoryStream);
                    json = reader.ReadString();
                    reader.Close();
                    memoryStream.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            var res = FromJson(json);
            return res;
        }

    

        private static byte[] Compress(byte[] data)
        {
            using MemoryStream memoryStream = new MemoryStream();
            using DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress);
            deflateStream.Write(data, 0, data.Length);
            deflateStream.Flush();
            deflateStream.Close();
            return memoryStream.ToArray();
        }
        private static byte[] Decompress(byte[] compressedData)
        {
            using MemoryStream memoryStream = new MemoryStream();
            using MemoryStream stream = new MemoryStream(compressedData);
            using DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
            deflateStream.CopyTo(memoryStream);
            memoryStream.Close();
            return memoryStream.ToArray();
        }
    }
}
