using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace PollinationSDK.Wrapper
{
    public class JobResultPackage
    {
        public string JobID { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string Recipe { get; set; }
        public bool IsCloudJob { get; set; }
        public string CloudProjectOwner { get; set; }
        public string CloudProjectName { get; set; }

        public string SavedLocalPath { get; set; }
        public string SelectedRunID { get; set; }
        //public DateTime DateTime { get; set; }

        //public string LoadAction { get; set; }

        //public List<string> Runs { get; set; }

        public List<RunInputAsset> RunInputAssets { get; set; }
        public List<RunOutputAsset> RunOutputAssets { get; set; }

        //[System.Runtime.Serialization.IgnoreDataMember]
        //public RunInfo RunInfo { get; set; }

        public string DisplayName => this.JobName ?? this.JobID.ToString().Substring(0, 8);


        [JsonConstructorAttribute]
        protected JobResultPackage()
        {
        }

        public JobResultPackage(ScheduledJobInfo job)
        {
            this.IsCloudJob = !job.IsLocalJob;
            this.JobID = job.JobID;

            if (this.IsCloudJob)
            {
                this.JobName = job.CloudJob.Spec.Name;
                this.JobDescription = job.CloudJob.Spec.Description;
                this.Recipe = $"{job.Recipe.Metadata.Name}:{job.Recipe.Metadata.Tag}";
                this.CloudProjectName = job.Project.Name;
                this.CloudProjectOwner = job.Project.Owner.Name;
                this.SavedLocalPath = Path.Combine(Path.GetTempPath(), "Pollination", job.JobID.Substring(0, 8));
            }
            else
            {
                this.JobName = job.JobID;
                this.Recipe = $"{job.Recipe.Metadata.Name}:{job.Recipe.Metadata.Tag}";
                this.SavedLocalPath = job.JobID.Replace("LOCAL:", "");
            }

            // get all outputs

            var run = job.GetRunInfo(0);
            //this.RunInfo = run;
            this.SelectedRunID = run.RunID;
            this.RunInputAssets = run.GetInputAssets();
            this.RunOutputAssets = run.GetOutputAssets("rhino");

            //this.DateTime = DateTime.Now;
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.None);
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

        public static JobResultPackage Deserialize_Binary(byte[] bytes)
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

        public static JobResultPackage FromJson(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JobResultPackage>(json);
        }

        public static List<JobResultPackage> FromJsonArray(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<JobResultPackage>>(json);
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
