/* 
 * Pollination Server
 *
 * Pollination Server OpenAPI Defintion
 *
 * The version of the OpenAPI document: 0.9.2
 * Contact: info@pollination.cloud
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using PollinationSDK.Client;
using PollinationSDK.Api;
using PollinationSDK.Model;

namespace PollinationSDK.Test
{
    /// <summary>
    ///  Class for testing OperatorsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OperatorsApiTests
    {
        private OperatorsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OperatorsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OperatorsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' OperatorsApi
            //Assert.IsInstanceOf(typeof(OperatorsApi), instance);
        }

        
        /// <summary>
        /// Test CreateOperator
        /// </summary>
        [Test]
        public void CreateOperatorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //RepositoryCreate repositoryCreate = null;
            //var response = instance.CreateOperator(owner, repositoryCreate);
            //Assert.IsInstanceOf(typeof(CreatedContent), response, "response is CreatedContent");
        }
        
        /// <summary>
        /// Test CreateOperatorPackage
        /// </summary>
        [Test]
        public void CreateOperatorPackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //NewOperatorPackage newOperatorPackage = null;
            //var response = instance.CreateOperatorPackage(owner, name, newOperatorPackage);
            //Assert.IsInstanceOf(typeof(CreatedContent), response, "response is CreatedContent");
        }
        
        /// <summary>
        /// Test DeleteOperator
        /// </summary>
        [Test]
        public void DeleteOperatorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //instance.DeleteOperator(owner, name);
            
        }
        
        /// <summary>
        /// Test DeleteOperatorOrgPermission
        /// </summary>
        [Test]
        public void DeleteOperatorOrgPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //RepositoryPolicySubject repositoryPolicySubject = null;
            //instance.DeleteOperatorOrgPermission(owner, name, repositoryPolicySubject);
            
        }
        
        /// <summary>
        /// Test GetOperator
        /// </summary>
        [Test]
        public void GetOperatorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //var response = instance.GetOperator(owner, name);
            //Assert.IsInstanceOf(typeof(Repository), response, "response is Repository");
        }
        
        /// <summary>
        /// Test GetOperatorAccessPermissions
        /// </summary>
        [Test]
        public void GetOperatorAccessPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //int page = null;
            //int perPage = null;
            //List<string> subjectType = null;
            //List<string> permission = null;
            //var response = instance.GetOperatorAccessPermissions(owner, name, page, perPage, subjectType, permission);
            //Assert.IsInstanceOf(typeof(RepositoryAccessPolicyList), response, "response is RepositoryAccessPolicyList");
        }
        
        /// <summary>
        /// Test GetOperatorByTag
        /// </summary>
        [Test]
        public void GetOperatorByTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //string tag = null;
            //var response = instance.GetOperatorByTag(owner, name, tag);
            //Assert.IsInstanceOf(typeof(OperatorPackage), response, "response is OperatorPackage");
        }
        
        /// <summary>
        /// Test ListOperatorTags
        /// </summary>
        [Test]
        public void ListOperatorTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //var response = instance.ListOperatorTags(owner, name);
            //Assert.IsInstanceOf(typeof(RepositoryPackageList), response, "response is RepositoryPackageList");
        }
        
        /// <summary>
        /// Test ListOperators
        /// </summary>
        [Test]
        public void ListOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int page = null;
            //int perPage = null;
            //List<string> name = null;
            //List<string> owner = null;
            //bool _public = null;
            //List<string> keyword = null;
            //List<string> permission = null;
            //var response = instance.ListOperators(page, perPage, name, owner, _public, keyword, permission);
            //Assert.IsInstanceOf(typeof(RepositoryList), response, "response is RepositoryList");
        }
        
        /// <summary>
        /// Test UpdateOperator
        /// </summary>
        [Test]
        public void UpdateOperatorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //RepositoryUpdate repositoryUpdate = null;
            //var response = instance.UpdateOperator(owner, name, repositoryUpdate);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
        /// <summary>
        /// Test UpsertOperatorPermission
        /// </summary>
        [Test]
        public void UpsertOperatorPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //RepositoryAccessPolicy repositoryAccessPolicy = null;
            //var response = instance.UpsertOperatorPermission(owner, name, repositoryAccessPolicy);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
    }

}