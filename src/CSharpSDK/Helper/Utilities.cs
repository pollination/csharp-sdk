
extern alias LBTNewtonsoft; extern alias LBTRestSharp; using System;
using PollinationSDK.Client;
using LBTRestSharp::RestSharp;
using System.IO;
using System.Linq;
using Pollination;

namespace PollinationSDK
{
    public static class Utilities
    {
        private static Microsoft.Extensions.Logging.ILogger Logger => LogUtils.GetLogger(typeof(Utilities));
        public static Version GetLatestVersion(string product)
        {
            var apiUrl = $"https://utilities.pollination.solutions/latest-version/{product}";

            var request = new RestRequest(Method.GET);
            request.Timeout = 3000;
            var client = new RestClient(apiUrl);
            var response = client.Execute(request);
            var version = response.Content?.Replace("\"", ""); //"1.2.9"
            var isValid = System.Version.TryParse(version, out var newVersion);
            return isValid ? newVersion : null;
        }

        public static string GetDownloadTheLatestVersionUrl(string product)
        {
            var apiUrl = $"https://utilities.pollination.solutions/download-plugin/{product}";
            return apiUrl;
        }

        /// <summary>
        /// Download a translated recipe for luigi
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="recipeName"></param>
        /// <param name="tag"></param>
        /// <returns>zip file path</returns>
        public static string GetCompiledRecipe(string owner, string recipeName, string tag = "latest")
        {
            var request = new RestRequest(Method.GET);
            //https://utilities.staging.pollination.solutions/luigi-archive
            var url = $"{Configuration.Default.BasePath}/luigi-archive".Replace("https://api.", "https://utilities.");


            // add Authorization JWT
            var jwt = Configuration.Default.AccessToken;
            // http beerer authentication required
            if (!String.IsNullOrEmpty(jwt))
            {
                request.AddHeader("Authorization", $"Bearer {jwt}");
            }

            // add API key
            var apiKey = Configuration.Default.GetApiKeyWithPrefix("x-pollination-token");
            if (!string.IsNullOrEmpty(apiKey))
            {
                request.AddHeader("x-pollination-token", apiKey);
            }

            if (!request.Parameters.Any())
            {
                Logger.ThrowError("Please login first for downloading recipes!");
             
            }

            request.AddParameter("owner", owner);
            request.AddParameter("name", recipeName);
            request.AddParameter("tag", tag);

            var client = new RestClient(url);
            var response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Logger.ThrowError($"HttpCode {(int)response.StatusCode}: Failed to download {recipeName}");
            }

            //{Content-Disposition=attachment; filename=annual-daylight-0.6.4.zip}
            var filename = response.Headers.FirstOrDefault(_ => _.Name.ToLower() == "content-disposition")?.Value?.ToString()?.Split('=')?.LastOrDefault();

            // prep file path
            var saveAsDir = RecipeCacheFolder;
            var fileName = string.IsNullOrEmpty(filename) ? $"{owner}_{recipeName}-{tag}.zip" : $"{owner}_{filename}";

            System.IO.Directory.CreateDirectory(saveAsDir);
            var file = System.IO.Path.Combine(saveAsDir, fileName);
            if (File.Exists(file))
                File.Delete(file);

            var b = response.RawBytes;
            System.IO.File.WriteAllBytes(file, b);
            if (!System.IO.File.Exists(file))
            {
                Logger.ThrowError($"Failed to save {fileName} to {file}");
            }
            return file;
        }

        public static string GetLocalRecipe(string owner, string recipeName, string tag)
        {
            if (tag == "latest")
                throw new ArgumentException("Recipe tag cannot be [latest], please use version number");

            var dir = RecipeCacheFolder;
            var search = $"{owner}_{recipeName}-{tag}";
            var files = Directory.GetFiles(dir, $"*{search}*", SearchOption.TopDirectoryOnly);

            var zipPath = string.Empty;
            // download from server
            if (!files.Any())
                zipPath = GetCompiledRecipe(owner, recipeName, tag);
            else
                zipPath = files.FirstOrDefault();
            // use local cache

            var localRecipe = new FileInfo(zipPath);
            var days = (System.DateTime.UtcNow - localRecipe.CreationTimeUtc).Days;
            if (days > 14) // re-download the recipe
            {
                Logger.Info("Re-downloading the recipe from server as the local cache has been expired");
                zipPath = GetCompiledRecipe(owner, recipeName, tag);
            }

            if (!File.Exists(zipPath))
            {
                Logger.ThrowError($"Failed to find {zipPath}");
            }
            var unzipTo = Path.Combine(dir, Path.GetFileNameWithoutExtension(zipPath));
            var outputDir = Helper.Unzip(zipPath, unzipTo, false);
            return outputDir;

        }

        public static bool IsMac => System.Environment.OSVersion.Platform == PlatformID.Unix;
        internal static string LadybugToolRoot { get; set; }
        internal static string PythonRoot { get; set; }
        internal static string RecipeCacheFolder
        {
            get { 
                var p = Path.Combine(Path.GetTempPath(), "Pollination", "Recipes");
                Directory.CreateDirectory(p);
                return p;
            }
        }

        //public static string ApplicationRoot => IsMac ?
        //  Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(typeof(Utilities).Assembly.Location))))) :
        //  Path.GetDirectoryName(Path.GetDirectoryName(typeof(Utilities).Assembly.Location));



        public static void SetPaths(string LBTFolder)
        {
            if (!Directory.Exists(LBTFolder))
                throw new ArgumentException($"{LBTFolder} doesn't exist!");
            LadybugToolRoot = LBTFolder;

            PythonRoot = Path.Combine(LadybugToolRoot, "python");
            if (!Directory.Exists(PythonRoot))
                throw new ArgumentException($"{PythonRoot} doesn't exist!");
        }

        public static string GetEnvArgForRadiance()
        {
            var radiance = Path.Combine(LadybugToolRoot, "radiance");
            var radBin = Path.Combine(radiance, "bin");
            var radLib = Path.Combine(radiance, "lib");

            if (Directory.Exists(radBin) && Directory.Exists(radLib))
            {
                var envArg = $" --env PATH=\"{radBin}\"";
                envArg += $" --env RAYPATH=\"{radLib}\"";
                return envArg;
            }
            return string.Empty;

        }

        /// <summary>
        /// Get a valid license key which is a not suspended or revoked.
        /// </summary>
        /// <param name="product">rhino_plugin or revit_plugin</param>
        /// <returns></returns>
        public static string GetValidLicenseKey(string product)
        {
            var api = new PollinationSDK.Api.LicensesApi();
            var pool = api.GetAvailablePools().Resources.Where(_ => _.Product == product).FirstOrDefault();
            if (pool == null)
                throw new ArgumentException($"Failed to find any available license pool for product: {product}");
            var id = pool.Id;
            Logger.Info($"Pool ID: {id}");
            var license = api.GetPoolLicense(id);
            if (license.Revoked)
                throw new ArgumentException($"License is revoked. ID: {pool.LicenseId}");
            if (license.Suspended)
                throw new ArgumentException($"License is suspended. ID: {pool.LicenseId}");
            return license.Key;

        }

    }
}
