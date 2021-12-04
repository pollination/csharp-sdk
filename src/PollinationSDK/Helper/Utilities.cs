using Cryptlex;
using PollinationSDK.Client;
using RestSharp;
using System;
using System.IO;
using System.Linq;

namespace PollinationSDK
{
    public static class Utilities
    {
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
            //https://utilities.staging.pollination.cloud/luigi-archive
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
                var e = new ArgumentException("Please login first for downloading recipes!");
                Helper.Logger.Error(e, $"GetCompiledRecipe: error");
                throw e;
            }

            request.AddParameter("owner", owner);
            request.AddParameter("name", recipeName);
            request.AddParameter("tag", tag);

            var client = new RestClient(url);
            var response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var e = new ArgumentException($"HttpCode {(int)response.StatusCode}: Failed to download {recipeName}");
                Helper.Logger.Error(e, $"GetCompiledRecipe: error");
                throw e;
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
                var e = new ArgumentException($"Failed to save {fileName} to {file}");
                Helper.Logger.Error(e, $"GetCompiledRecipe: error");
                throw e;
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
                Helper.Logger.Information("Re-downloading the recipe from server as the local cache has been expired");
                zipPath = GetCompiledRecipe(owner, recipeName, tag);
            }

            if (!File.Exists(zipPath))
            {
                var e = new ArgumentException($"Failed to find {zipPath}");
                Helper.Logger.Error(e, $"GetLocalRecipe: error");
                throw e;
            }
            var unzipTo = Path.Combine(dir, Path.GetFileNameWithoutExtension(zipPath));
            var outputDir = Helper.Unzip(zipPath, unzipTo, false);
            return outputDir;

        }

        public static bool IsMac => System.Environment.OSVersion.Platform == PlatformID.Unix;
        public static string LadybugToolRoot { get; set; }
        public static string PythonRoot { get; set; }
        public static string RecipeCacheFolder
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


        private static bool _isLicensed;
        public static bool IsPluginLicensed => _isLicensed;

        /// <summary>
        /// Call this before using ActivateLicense() or CheckLicense()
        /// </summary>
        public static void SetupLicenseLexActivator(string productData, string productId, string appVersion)
        {
            LexActivator.SetProductData(productData);
            LexActivator.SetProductId(productId, LexActivator.PermissionFlags.LA_USER);
            LexActivator.SetAppVersion(appVersion);
        }

        public static bool CheckIfLicensed(out string message, bool forceToCheck = false)
        {
            message = string.Empty;
            try
            {
                if (_isLicensed && !forceToCheck)
                {
                    message = "License is activated";
                    return true;
                }

                _isLicensed = false;

                var userID = CheckActivationUserID();
                int status = LexActivator.IsLicenseGenuine();
                if (LexStatusCodes.LA_OK == status)
                {
                    message = GetActivationInfo(userID);
                    _isLicensed = true;
                    return _isLicensed;

                    // Checking for software release update
                    // LexActivator.CheckForReleaseUpdate("windows", "1.0.0", "stable", SoftwareReleaseUpdateCallback);
                }
                else if (LexStatusCodes.LA_EXPIRED == status)
                {
                    message = $"License has expired. You can renew the license from Pollination.";
                    return _isLicensed;
                }
                else if (LexStatusCodes.LA_GRACE_PERIOD_OVER == status)
                {
                    message = $"License is genuinely activated but grace period is over. You can renew the license from Pollination.";
                    return _isLicensed;
                }
                else if (LexStatusCodes.LA_SUSPENDED == status)
                {
                    message = $"License is genuinely activated but has been suspended. You can manage the license from Pollination.";
                    return _isLicensed;
                }

                else
                {
                    var savedKey = LexActivator.GetLicenseKey();
                    if (!string.IsNullOrEmpty(savedKey) && ActivateLicense(savedKey, out var activateMsg))
                    {
                        message = activateMsg;
                        _isLicensed = true;
                        return _isLicensed;
                    }
                    else if (TryActivateTrial(out var trialMsg))
                    {
                        message = trialMsg;
                        _isLicensed = true;
                        return _isLicensed;
                    }
                    else
                    {
                        message = "Pollination license is not activated. Please check the Pollination website to get a valid license. \n Error message: " + status.ToString();
                        return _isLicensed;
                    }

                }
            }
            catch (LexActivatorException ex)
            {
                message = "Pollination license is not valid. Error code: " + ex.Code.ToString() + " Error message: " + ex.Message;
                return false;
            }
        }


        public static bool ActivateLicense(string key, out string message)
        {
            message = string.Empty;

            try
            {
                int status;
                string userID = string.Empty;
                try
                {
                    userID = CheckActivationUserID();
                    LexActivator.SetLicenseKey(key);
                    status = LexActivator.ActivateLicense();
                }
                catch (LexActivatorException ex)
                {
                    //clear the key if a key is invalid
                    LexActivator.DeactivateLicense();
                    message = "Error code: " + ex.Code.ToString() + "\nError message: " + ex.Message;
                    return false;
                    // handle error
                }

                if (status == LexStatusCodes.LA_OK || status == LexStatusCodes.LA_EXPIRED || status == LexStatusCodes.LA_SUSPENDED)
                {
                    // Activation successful
                    message = GetActivationInfo(userID);
                    return true;
                }
                else
                {
                    // Activation failed
                    message = "Invalid license! Please check the Pollination website to get a valid license. \nError message: " + status.ToString();
                    return false;
                }
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.ToString();
                return false;
            }
        }

        private static string CheckActivationUserID(bool isTrial = false)
        {
            var user = string.Empty;
            try
            {
                user = isTrial ? LexActivator.GetTrialActivationMetadata("POID") : LexActivator.GetActivationMetadata("POID");
            }
            catch (Exception)
            {
            }

            if (string.IsNullOrEmpty(user))
            {
                user = Helper.CurrentUser?.Username ?? "unknown";
                if (isTrial)
                    LexActivator.SetTrialActivationMetadata("POID", user);
                else
                    LexActivator.SetActivationMetadata("POID", user);
            }


            return user;
        }

        private static string GetActivationInfo(string userID)
        {
            uint expiryDate = LexActivator.GetLicenseExpiryDate();
            int secondsLeft = (int)(expiryDate - (uint)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
            int daysLeft = secondsLeft / 86400;
            var licenseType = LexActivator.GetLicenseType();
            var date = DateTime.UtcNow.AddSeconds(secondsLeft).ToLocalTime();
            var message = $"License ({licenseType}) is activated to {userID} with {daysLeft} days left.\nYour license will be renewed on {date.ToShortDateString()} for another month.";
            return message;
        }
        private static bool TryActivateTrial(out string message)
        {
            try
            {
                int trialStatus;
                CheckActivationUserID(true);
                trialStatus = LexActivator.IsTrialGenuine();
                if (LexStatusCodes.LA_OK == trialStatus)
                {
                    uint trialExpiryDate = LexActivator.GetTrialExpiryDate();
                    int daysLeft = (int)(trialExpiryDate - (uint)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds) / 86400;
                    var trialId = LexActivator.GetTrialId();
                    message = $"Your trial license will be expired in {daysLeft} days.\nTrial ID: {trialId}";
                    return true;
                }
                else if (LexStatusCodes.LA_TRIAL_EXPIRED == trialStatus)
                {
                    var trialId = LexActivator.GetTrialId();
                    message = $"Trial has expired! You can buy a new license from Pollination.\nTrial ID: {trialId}";
                    return false;
                }
                else
                {
                    // Activating the trial
                    trialStatus = LexActivator.ActivateTrial(); // Ideally on a button click inside a dialog
                    if (LexStatusCodes.LA_OK == trialStatus)
                    {
                        uint trialExpiryDate = LexActivator.GetTrialExpiryDate();
                        int daysLeft = (int)(trialExpiryDate - (uint)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds) / 86400;
                        var trialId = LexActivator.GetTrialId();
                        message = $"Your license will be expired in {daysLeft} days.\nTrial ID: {trialId}";
                        return true;
                    }
                    else
                    {
                        // Trial was tampered or has expired
                        var trialId = LexActivator.GetTrialId();
                        message = $"Trial activation failed: {trialStatus}! You can buy a new license from Pollination.\nTrial ID: {trialId}";
                        return false;
                    }
                }
            }
            catch (LexActivatorException ex)
            {
                message = "Error code: " + ex.Code.ToString() + " Error message: " + ex.Message;
                return false;
            }

        }


    }
}
