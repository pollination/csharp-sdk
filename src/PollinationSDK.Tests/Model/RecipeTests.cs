
using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using PollinationSDK.Api;
using PollinationSDK.Client;
using System.Reflection;
using Newtonsoft.Json;
using System.Net;
using QueenbeeSDK;

namespace PollinationSDK.Test
{
    /// <summary>
    ///  Class for testing RecipePackage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RecipeTests
    {
        private RecipeInterface daylightFactor;
        private RecipeInterface annualDaylight;

        [SetUp]
        public void Init()
        {
            
            using (WebClient wc = new WebClient())
            {
                // Annual daylight
                var url = @"https://api.staging.pollination.cloud/recipes/ladybug-tools/annual-daylight/tags/latest";
                var json = wc.DownloadString(url);
                this.annualDaylight = RecipeInterface.FromJson(json);

                // Daylight factor
                url = @"https://api.staging.pollination.cloud/recipes/ladybug-tools/daylight-factor/tags/latest";
                json = wc.DownloadString(url);
                this.daylightFactor = RecipeInterface.FromJson(json);
            }

            //var file = @"../../../testResources/RecipePackage.json";
            //var text = File.ReadAllText(file);
            //instance = RecipePackage.FromJson(text);
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecipePackage
        /// </summary>
        [Test]
        public void RecipeInstanceTest()
        {
            Assert.IsTrue(this.annualDaylight != null);
            Assert.IsTrue(this.daylightFactor != null);
        }


        [Test]
        public void InputOutputTest()
        {
            Assert.IsTrue(this.annualDaylight.Inputs.Count > 0);
            Assert.IsTrue(this.annualDaylight.Outputs.Count > 0);

            Assert.IsTrue(this.daylightFactor.Inputs.Count > 0);
            Assert.IsTrue(this.daylightFactor.Outputs.Count > 0);
        }

        [Test]
        public void ReadmeTest()
        {
            Assert.IsTrue(!string.IsNullOrEmpty(this.daylightFactor.Source));
            Assert.IsTrue(!string.IsNullOrEmpty(this.annualDaylight.Source));
        }
        [Test]
        public void TagTest()
        {
            Assert.IsTrue(this.annualDaylight.Metadata.Tag != "latest");

            Assert.IsTrue(this.daylightFactor.Metadata.Tag != "latest");
        }

        [Test]
        public void ToJson()
        {
            Assert.IsTrue(this.annualDaylight.Metadata.Equals(this.annualDaylight.Metadata.DuplicateMetaData()));

            var inputs = this.annualDaylight.Inputs.OfType<GenericInput>();
            Assert.IsTrue(inputs.Count() == this.annualDaylight.Inputs.Count);
            foreach (var item in inputs)
            {
                Assert.IsTrue(item.Equals(item.Duplicate()));
            }

            var outputs = this.annualDaylight.Outputs.OfType<GenericOutput>();
            Assert.IsTrue(outputs.Count() == this.annualDaylight.Outputs.Count);
            foreach (var item in outputs)
            {
                Assert.IsTrue(item.Equals(item.Duplicate()));
            }


            //Assert.IsTrue(this.annualDaylight.Inputs.First().Equals(this.annualDaylight.Inputs.First().));

            var dup1 = this.annualDaylight.Duplicate();
            Assert.IsTrue(dup1.Equals(this.annualDaylight));

            var dup2 = this.daylightFactor.DuplicateRecipeInterface();
            var a = this.daylightFactor.Duplicate();
            Assert.IsTrue(this.daylightFactor.Equals(dup2));
        }

    }

}
