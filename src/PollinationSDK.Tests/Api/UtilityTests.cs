using NUnit.Framework;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Wrapper;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PollinationSDK.Test
{
    [TestFixture]
    public class UtilityTests
    {
        [Test]
        public void TestConnectivityTest()
        {
            var available = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            Assert.IsTrue(available);

        }

        [Test]
        public void TestGetLatestVersion()
        {
            var version = Utilities.GetLatestVersion("rhino");
            Assert.IsTrue(version != null);
        }

        [Test]
        public void TestDownloadFolder()
        {
            var api = new ArtifactsApi();
            var relativeFolderPath = new List<string> { "testSubDir" };
            var projOwner = "ladybug-tools";
            var projName = "demo";


            var pathes = Helper.GetAllFilesAsync(api, projOwner, projName, relativeFolderPath, "").GetAwaiter().GetResult();
            Assert.IsTrue(pathes != null);
            Assert.IsTrue(pathes.Count() > 3);
        }



        //[Test]
        //public void DownloadRecipeTest()
        //{
        //    //public recipe
        //    var zipfile = Utilities.GetCompiledRecipe("ladybug-tools", "annual-daylight", "latest");
        //    Assert.IsTrue(System.IO.File.Exists(zipfile));

        //    //private recipe
        //    var privatefile = Utilities.GetCompiledRecipe("pollination", "leed-daylight-illuminance", "latest");
        //    Assert.IsTrue(System.IO.File.Exists(privatefile));
        //}

        //[Test]
        //public void GetLocalRecipeTest()
        //{
        //    var recipeOwner = "ladybug-tools";
        //    var recipeName = "annual-daylight";
        //    var recipeApi = new RecipesApi();
        //    var rec = recipeApi.GetRecipeByTag(recipeOwner, recipeName, "latest").Manifest;

        //    //public recipe
        //    var recipeFolder = Utilities.GetLocalRecipe(recipeOwner, recipeName, rec.Metadata.Tag);
        //    Assert.IsTrue(System.IO.Directory.GetFiles(recipeFolder).Any());
        //}

        //[Test]
        //public void RunLocalTest()
        //{

        //    var recipeOwner = "ladybug-tools";
        //    var recipeName = "annual-energy-use";
        //    var recipeApi = new RecipesApi();
        //    var rec = recipeApi.GetRecipeByTag(recipeOwner, recipeName, "latest").Manifest;

        //    var jobInfo = new JobInfo(rec);

        //    var model = Path.GetFullPath(@"../../../TestSample/Room.hbjson");
        //    if (!File.Exists(model))
        //        throw new ArgumentException("Input doesn't exist");
        //    jobInfo.AddArgument(new JobPathArgument("model", new ProjectFolder(path: model)));

        //    jobInfo.SetJobSubFolderPath("round1/test");
        //    jobInfo.SetJobName("A new daylight simulation");



        //    // run a job
        //    var path = @"C:\Users\mingo\simulation";
        //    var lbt = @"C:\Users\mingo\ladybug_tools";
        //    Utilities.SetPaths(lbt);
        //    var job = jobInfo.RunJobOnLocal(path, 5);
        //    //runID: LOCAL:C:\Users\mingo\simulation\Anewdaylightsimulation\round1/test

        //    //Assert.IsTrue(!string.IsNullOrEmpty(ScheduledJob.CloudJob.Id));

        //}

        //[Test]
        //public void LoadLocalResultTest()
        //{
        //    //LOCAL:C:\Users\mingo\simulation\Anewdaylightsimulation\round1/test
        //    var run = RunInfo.LoadFromLocalFolder(@"C:\Users\mingo\simulation\Anewdaylightsimulation\round1/test");
        //    var inputs = run.GetInputAssets();
        //    var outputs = run.GetOutputAssets("grasshopper");

        //    var assets = new List<RunAssetBase>();
        //    assets.AddRange(inputs);
        //    assets.AddRange(outputs);
        //    var loadedAssets = run.LoadLocalRunAssets(assets);

        //}

        //[Test]
        //public void LoadLocalResultTest()
        //{

        //    var proj = Helper.GetAProject("mingbo", "demo");
        //    var path = "pzlolgsa.ume.hbjson";
        //    var file = new FileMeta(path, "file", "test.hbjson");

        //    var saveAs = Path.GetTempPath();
        //    var task = Helper.DownloadArtifact(proj, file, saveAs);
        //    var saved = task.GetAwaiter().GetResult();
        //    Assert.IsTrue(File.Exists(saved));

        //}
    }

}
