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
    ///  Class for testing TeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TeamsApiTests
    {
        private TeamsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TeamsApi
            //Assert.IsInstanceOf(typeof(TeamsApi), instance);
        }

        
        /// <summary>
        /// Test CreateTeam
        /// </summary>
        [Test]
        public void CreateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //TeamCreate teamCreate = null;
            //var response = instance.CreateTeam(orgName, teamCreate);
            //Assert.IsInstanceOf(typeof(CreatedContent), response, "response is CreatedContent");
        }
        
        /// <summary>
        /// Test DeleteOrgTeamMember
        /// </summary>
        [Test]
        public void DeleteOrgTeamMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //string teamSlug = null;
            //string username = null;
            //instance.DeleteOrgTeamMember(orgName, teamSlug, username);
            
        }
        
        /// <summary>
        /// Test DeleteTeam
        /// </summary>
        [Test]
        public void DeleteTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //string teamSlug = null;
            //instance.DeleteTeam(orgName, teamSlug);
            
        }
        
        /// <summary>
        /// Test GetOrgTeamMembers
        /// </summary>
        [Test]
        public void GetOrgTeamMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //string teamSlug = null;
            //int page = null;
            //int perPage = null;
            //var response = instance.GetOrgTeamMembers(orgName, teamSlug, page, perPage);
            //Assert.IsInstanceOf(typeof(TeamMemberList), response, "response is TeamMemberList");
        }
        
        /// <summary>
        /// Test GetTeam
        /// </summary>
        [Test]
        public void GetTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //string teamSlug = null;
            //var response = instance.GetTeam(orgName, teamSlug);
            //Assert.IsInstanceOf(typeof(Team), response, "response is Team");
        }
        
        /// <summary>
        /// Test ListOrgTeams
        /// </summary>
        [Test]
        public void ListOrgTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //int page = null;
            //int perPage = null;
            //List<string> name = null;
            //List<string> member = null;
            //var response = instance.ListOrgTeams(orgName, page, perPage, name, member);
            //Assert.IsInstanceOf(typeof(TeamList), response, "response is TeamList");
        }
        
        /// <summary>
        /// Test UpdateTeam
        /// </summary>
        [Test]
        public void UpdateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //string teamSlug = null;
            //TeamUpdate teamUpdate = null;
            //var response = instance.UpdateTeam(orgName, teamSlug, teamUpdate);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
        /// <summary>
        /// Test UpsertOrgTeamMember
        /// </summary>
        [Test]
        public void UpsertOrgTeamMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //string teamSlug = null;
            //string username = null;
            //TeamRoleEnum role = null;
            //var response = instance.UpsertOrgTeamMember(orgName, teamSlug, username, role);
            //Assert.IsInstanceOf(typeof(UpdateAccepted), response, "response is UpdateAccepted");
        }
        
    }

}
