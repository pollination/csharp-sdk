/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.2
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using PollinationSDK.Api;
using PollinationSDK.Model;
using PollinationSDK.Client;
using System.Reflection;
using Newtonsoft.Json;
using System.Net;

namespace PollinationSDK.Test
{
    /// <summary>
    ///  Class for testing RecipePackage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RecipePackageTests
    {
        // TODO uncomment below to declare an instance variable for RecipePackage
        private RecipePackage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RecipePackage
            var url = @"https://api.staging.pollination.cloud/recipes/ladybug-tools/annual-daylight/tags/latest";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                this.instance = RecipePackage.FromJson(json);
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
        public void RecipePackageInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" RecipePackage
            Assert.IsInstanceOf(typeof(RecipePackage), instance);
        }


        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Digest'
        /// </summary>
        [Test]
        public void DigestTest()
        {
            // TODO unit test for the property 'Digest'
        }
        /// <summary>
        /// Test the property 'Icon'
        /// </summary>
        [Test]
        public void IconTest()
        {
            // TODO unit test for the property 'Icon'
        }
        /// <summary>
        /// Test the property 'Keywords'
        /// </summary>
        [Test]
        public void KeywordsTest()
        {
            // TODO unit test for the property 'Keywords'
        }
        /// <summary>
        /// Test the property 'License'
        /// </summary>
        [Test]
        public void LicenseTest()
        {
            // TODO unit test for the property 'License'
        }
        /// <summary>
        /// Test the property 'Manifest'
        /// </summary>
        [Test]
        public void ManifestTest()
        {
            var mainFlow = this.instance.Manifest.Flow.FirstOrDefault(_ => _.Name == "main");
           
            Assert.IsTrue(mainFlow.Inputs.Artifacts.Count > 0);
            Assert.IsTrue(mainFlow.Inputs.Parameters.Count > 0);
        }
        /// <summary>
        /// Test the property 'Readme'
        /// </summary>
        [Test]
        public void ReadmeTest()
        {
            // TODO unit test for the property 'Readme'
        }
        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Test]
        public void TagTest()
        {
            var tag = this.instance.Tag;
            Assert.IsTrue(tag != "latest");
        }

    }

}
