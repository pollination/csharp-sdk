
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

namespace PollinationSDK.Test
{
    [TestFixture]
    public class ProjectsApiTests
    {
        private ProjectsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProjectsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ProjectsApi
            //Assert.IsInstanceOf(typeof(ProjectsApi), instance);
        }

        
        /// <summary>
        /// Test CreateProject
        /// </summary>
        [Test]
        public void CreateProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //ProjectCreate projectCreate = null;
            //var response = instance.CreateProject(owner, projectCreate);
            //Assert.IsInstanceOf(typeof(CreatedContent), response, "response is CreatedContent");
        }
        
        /// <summary>
        /// Test CreateProjectRecipeFilter
        /// </summary>
        [Test]
        public void CreateProjectRecipeFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //ProjectRecipeFilter projectRecipeFilter = null;
            //var response = instance.CreateProjectRecipeFilter(owner, name, projectRecipeFilter);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
        /// <summary>
        /// Test DeleteProject
        /// </summary>
        [Test]
        public void DeleteProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //instance.DeleteProject(owner, name);
            
        }
        
        /// <summary>
        /// Test DeleteProjectOrgPermission
        /// </summary>
        [Test]
        public void DeleteProjectOrgPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //ProjectPolicySubject projectPolicySubject = null;
            //instance.DeleteProjectOrgPermission(owner, name, projectPolicySubject);
            
        }
        
        /// <summary>
        /// Test DeleteProjectRecipeFilter
        /// </summary>
        [Test]
        public void DeleteProjectRecipeFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //ProjectRecipeFilter projectRecipeFilter = null;
            //instance.DeleteProjectRecipeFilter(owner, name, projectRecipeFilter);
            
        }
        
        /// <summary>
        /// Test GetProject
        /// </summary>
        [Test]
        public void GetProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //var response = instance.GetProject(owner, name);
            //Assert.IsInstanceOf(typeof(Project), response, "response is Project");
        }
        
        /// <summary>
        /// Test GetProjectAccessPermissions
        /// </summary>
        [Test]
        public void GetProjectAccessPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //int page = null;
            //int perPage = null;
            //List<string> subjectType = null;
            //List<string> permission = null;
            //var response = instance.GetProjectAccessPermissions(owner, name, page, perPage, subjectType, permission);
            //Assert.IsInstanceOf(typeof(ProjectAccessPolicyList), response, "response is ProjectAccessPolicyList");
        }
        
        /// <summary>
        /// Test GetProjectRecipeFilters
        /// </summary>
        [Test]
        public void GetProjectRecipeFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //var response = instance.GetProjectRecipeFilters(owner, name);
            //Assert.IsInstanceOf(typeof(ProjectRecipeFilterList), response, "response is ProjectRecipeFilterList");
        }
        
        /// <summary>
        /// Test GetProjectRecipes
        /// </summary>
        [Test]
        public void GetProjectRecipesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //int page = null;
            //int perPage = null;
            //var response = instance.GetProjectRecipes(owner, name, page, perPage);
            //Assert.IsInstanceOf(typeof(RepositoryList), response, "response is RepositoryList");
        }
        
        /// <summary>
        /// Test ListProjects
        /// </summary>
        [Test]
        public void ListProjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int page = null;
            //int perPage = null;
            //List<string> id = null;
            //List<string> name = null;
            //List<string> owner = null;
            //bool _public = null;
            //List<string> _operator = null;
            //var response = instance.ListProjects(page, perPage, id, name, owner, _public, _operator);
            //Assert.IsInstanceOf(typeof(ProjectList), response, "response is ProjectList");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //ProjectUpdate projectUpdate = null;
            //var response = instance.Update(owner, name, projectUpdate);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
        /// <summary>
        /// Test UpsertProjectPermission
        /// </summary>
        [Test]
        public void UpsertProjectPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string name = null;
            //ProjectAccessPolicy projectAccessPolicy = null;
            //var response = instance.UpsertProjectPermission(owner, name, projectAccessPolicy);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
    }

}
