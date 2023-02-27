using NUnit.Framework;
using System;

namespace PollinationSDK.Test
{
    [SetUpFixture]
    public class TestInit
    {

        //[OneTimeSetUp]
        //public void Init()
        //{
        //    var useDevelopmentServer = false;
        //    var key = string.Empty;

        //    // for local development tests, you must add Api key to ApiKey.txt
        //    var keyPath = useDevelopmentServer? @"../../../ApiKey.txt": @"../../../ApiKey_production.txt";

        //    if (System.IO.File.Exists(keyPath))
        //        key = System.IO.File.ReadAllText(keyPath);
        //    else
        //        key = useDevelopmentServer? Environment.GetEnvironmentVariable("PollinationApiKey"): Environment.GetEnvironmentVariable("PollinationApiKeyProduction");


        //    if (string.IsNullOrEmpty(key))
        //        throw new ArgumentException("Invalid Pollination ApiKey");


        //    var apiAuthentication = key;
        //    var task = System.Threading.Tasks.Task.Run(async () => await AuthHelper.SignInWithApiAuthAsync(apiAuthentication, null, devEnv: useDevelopmentServer));
        //    task.Wait();
        //}
    }
}
