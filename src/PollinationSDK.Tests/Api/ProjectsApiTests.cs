using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PollinationSDK.Api;


namespace PollinationSDK.Test
{
    [TestFixture]
    public class ProjectsApiTests
    {
        private ProjectsApi api;
        private string NewProject = $"{Guid.NewGuid().ToString().Substring(0, 8)}";
        private Project Project;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            api = new ProjectsApi();
            Project = CreateProject(NewProject);
           

        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [OneTimeTearDown]
        public void Cleanup()
        {
            DeleteProject(NewProject);
        }


        
        public Project CreateProject(string projName)
        {
            var projs = api.ListProjects(owner: new List<string>() { Helper.CurrentUser.Username }).Resources;
            var found = projs.FirstOrDefault(_ => _.Name == this.NewProject);

            var owner = Helper.CurrentUser.Username;
            var projectCreate = new ProjectCreate(projName);
            var response = api.CreateProject(owner, projectCreate);
            var proj = api.GetProject(owner, projName);
            return proj;
        }

        public void DeleteProject(string projName)
        {
            var owner = Helper.CurrentUser.Username;
            api.DeleteProject(owner, projName);
            
        }

        [Test]
        public void CreateProjectRecipeFilterTest()
        {
            var response = Wrapper.JobRunner.CheckRecipeInProject("ladybug-tools", "daylight-factor", this.Project);
            Assert.IsTrue(!string.IsNullOrEmpty(response));

            var filters = api.GetProjectRecipeFilters(Helper.CurrentUser.Username, Project.Name).Resources;
            Assert.IsTrue(filters.FirstOrDefault().Name == "daylight-factor");

            // delete recipe filter test
            var projectRecipeFilter = new ProjectRecipeFilter("ladybug-tools", "daylight-factor");
            api.DeleteProjectRecipeFilter(this.Project.Owner.Name, this.Project.Name, projectRecipeFilter);

            filters = api.GetProjectRecipeFilters(Helper.CurrentUser.Username, Project.Name).Resources;
            Assert.IsTrue(filters.Count == 0);
        }
        

       
        
        
        /// <summary>
        /// Test ListProjects
        /// </summary>
        [Test]
        public void ListProjectsTest()
        {
            var response = api.ListProjects(owner: new List<string>() {Helper.CurrentUser.Username });
            var projs = response.Resources;
            foreach (var item in projs)
            {
                Console.WriteLine($"projects: {item.Owner.Name}/{item.Name}");
            }
            Assert.IsTrue(projs.Count > 1);

            var found = projs.FirstOrDefault(_ => _.Name == this.NewProject);
            Assert.IsTrue(found != null);
        }
        
        
        
    }

}
