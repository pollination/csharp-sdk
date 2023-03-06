using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Text;

namespace PollinationSDK.Wrapper
{
    /// <summary>
    /// Once a job (ScheduledJobInfo) is completed, use this class to prepare/download/postprocess a run's outputs
    /// </summary>
    public class JobResultPackage
    {
        public string JobID { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string Recipe { get; set; }
        public bool IsCloudJob { get; set; }

        public string ProjectOwner { get; set; }
        public string ProjectName { get; set; }
        public string ProjectSlug => $"{ProjectOwner}/{ProjectName}";

        public string SavedLocalPath { get; set; }

        public string SelectedRunID { get; set; }

        public List<RunInputAsset> RunInputAssets { get; set; }
        public List<RunOutputAsset> RunOutputAssets { get; set; }

        [IgnoreDataMember]
        private ScheduledJobInfo SchJobInfo { get; set; }

        [IgnoreDataMember]
        public string DisplayName => this.JobName ?? this.JobID.ToString().Substring(0, 8);


        [JsonConstructorAttribute]
        protected JobResultPackage()
        {
        }

        public JobResultPackage(ScheduledJobInfo job)
        {
            this.IsCloudJob = !job.IsLocalJob;
            this.JobID = job.JobID;

        
     
            this.Recipe = $"{job.Recipe.Metadata.Name}:{job.Recipe.Metadata.Tag}";
            this.SavedLocalPath = job.SavedLocalPath;

            if (this.IsCloudJob)
            {
                this.JobName = job.CloudJob.Spec.Name;
                this.JobDescription = job.CloudJob.Spec.Description;
                this.ProjectName = job.CloudProject.Name;
                this.ProjectOwner = job.CloudProject.Owner.Name;

            }
            else
            {
                this.JobName = job.JobID;
                var projSlug = job.ProjectSlug.Split('/');

                this.ProjectName = projSlug[0];
                this.ProjectOwner = projSlug[1];
            }

            this.SchJobInfo = job;

            //this.DateTime = DateTime.Now;
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.None);
        }

        public static JobResultPackage FromJson(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobResultPackage>(json);
        }

        

       
        public void UpdateRunAssets(int runIndex = 0, string platform = "rhino")
        {
            // get all outputs
            var run = this.SchJobInfo.GetRunInfo(runIndex);
            //this.RunInfo = run;
            this.SelectedRunID = run.RunID;
            this.RunInputAssets = run.GetInputAssets();
            this.RunOutputAssets = run.GetOutputAssets(platform);
        }


    }
}
