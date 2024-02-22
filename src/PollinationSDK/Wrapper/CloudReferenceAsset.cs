using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace PollinationSDK.Wrapper
{
    public class CloudReferenceAsset : PollinationSDK.Wrapper.AssetBase
    {
        private static readonly string _cloudReferenceAssetKey = "CloudReferenceAsset";
        public string ProjectSlug { get; set; }
        public bool IsCloudJobReferenceAsset => !this.RunSource.EndsWith(_cloudReferenceAssetKey);
        public string JobId => IsCloudJobReferenceAsset ? this.RunSource.Split('/').LastOrDefault() : string.Empty;

        [JsonConstructorAttribute]
        public CloudReferenceAsset()
        {
            
        }


        public CloudReferenceAsset(string projOwner, string projName, string assetPath, string pathType = "file")
        {
            // get name
            this.Name = System.IO.Path.GetFileNameWithoutExtension(assetPath);

            // check path type
            this.PathType = pathType;
            this.RelativePath = assetPath;
            this.ProjectSlug = $"{projOwner}/{projName}";

            this.Description = $"CLOUD:{ProjectSlug}/{RelativePath}";

            this.RunSource = $"CLOUD:{ProjectSlug}/{_cloudReferenceAssetKey}";
        }

        public CloudReferenceAsset(string projOwner, string projName, string jobID, string assetPath, string pathType)
        {
            // get name
            this.Name = System.IO.Path.GetFileNameWithoutExtension(assetPath);


            // check path type
            this.PathType = pathType;
            this.RelativePath = assetPath;
            this.ProjectSlug = $"{projOwner}/{projName}";

            this.Description = $"CLOUD:{ProjectSlug}/{jobID}/{RelativePath}";

            this.RunSource = $"CLOUD:{ProjectSlug}/{jobID}";
        }

        public override string ToString()
        {
            return this.Description;
            //return this.ToJobPathArgument().ToUserFriendlyString(true);
        }


        public JobPathArgument ToJobPathArgument()
        {
            var projSlug = this.ProjectSlug;
            var assetPath = this.RelativePath;

            var pSource = new ProjectFolder(path: assetPath);
            var newPath = new JobPathArgument(string.Empty, pSource);
            newPath.IsAssetUploaded(true);
            newPath.TagCloudProjectSlug(projSlug);

            return newPath;
        }

        public static CloudReferenceAsset FromJobPathArgument(JobPathArgument arg)
        {
            if(!arg.IsAssetUploaded())
                throw new ArgumentException($"{arg.Name} is not a valid cloud-based argument");


            var projSlug = arg.CloudProjectSlug();
            var arr = projSlug.Split('/');
            var projOwner = arr[0];
            var projName = arr[1];
            var relativePath = (arg.Source.Obj as ProjectFolder).Path;
        
            var asset = new CloudReferenceAsset(projOwner, projName, relativePath);
            return asset;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cloudReferenceLink">CLOUD:owner-name/project-name/asset-path.epw</param>
        public static CloudReferenceAsset FromString(string cloudReferenceLink)
        {
            if (!cloudReferenceLink.StartsWith("CLOUD:"))
                throw new ArgumentException($"Invalid Path: {cloudReferenceLink}.\nFormat:\nCLOUD:owner-name/project-name/asset-path.epw");


            var text = cloudReferenceLink.Substring(6);
            var arrs = text.Split('/');

            var projOwner = arrs[0];
            var projName = arrs[1];
            var assetPath = string.Join("/", arrs.Skip(2));
            var asset = new CloudReferenceAsset(projOwner, projName, assetPath);
            return asset;
        }

        public override PollinationSDK.Wrapper.AssetBase Duplicate()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.None);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CloudReferenceAsset>(json);
        }

        public override RunInfo GetRunInfo()
        {
            return null;
        }

        internal override bool CheckIfAssetCached(string dir)
        {
            var file = Path.GetFullPath(Path.Combine(dir, Path.GetFileName(this.RelativePath)));
            return File.Exists(file);
        }
    }
}
