
using FluentAssertions;
using Newtonsoft.Json;
using Roughcut.Atlassian.ClientServices.Dtos;
using Roughcut.Atlassian.ClientServices.Models;
using Roughcut.Atlassian.DataStorage.Base;
using Roughcut.Atlassian.DataStorage.DbContexts;
using Roughcut.Atlassian.DataStorage.DbModels;
using Roughcut.Atlassian.Interfaces.Jira;
using Roughcut.Atlassian.Interfaces.TestCases;

namespace Roughcut.Atlassian.Integration.Tests.Integration
{
    public class JiraApiTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TestCase("KBGL")]
        public void Should_TestProjectDirectory(string projectKey)
        {
            string testingDirectory = Testing.TestingDirectory();

            string jiraItemJsonFile = $"JiraProject.{projectKey}.json";

            string jiraArtifactFullPath = Testing.TestingDirectory + jiraItemJsonFile;


            var path = Path.Combine(Testing.TestingDirectory(), "TestCases", jiraItemJsonFile);
        }

        [TestCase]
        public async Task Should_GetAndStoreProtos()
        {
            string jiraBaseUrl = "https://jira-cloud-demo.atlassian.net/rest/api/2";

            // arrange / act
            RestClientBase<ProjectDto> restClient = new RestClientBase<ProjectDto>(jiraBaseUrl);

            // get jira projects from api
            var projects = await restClient.GetListAsync();

            // and store in db, if not present
            var db = new JiraDbContext();

            foreach (IProject project in projects)
            {

                // 
                var dbProject = db.Projects.FirstOrDefault(p => p.Key == project.Key);

                // convert to db model
                //Project dbProjectModel = new Project
                //{
                //    Name = project.Name,
                //    Key = project.Key,
                //    Description = project.Description,
                //    Components = project.Components,
                //    //Issues = project.Issues
                //};

                Project dbProjectModel = (Project)project;

                if (dbProject == null)
                {
                    project.Components.Add("");

                    // add description, if null or empty
                    if (string.IsNullOrEmpty(project.Description))
                    {
                        project.Description = "No description available.";
                    }

                    db.Projects.Add(dbProjectModel);
                }
            }

            // save changes
            await db.SaveChangesAsync();

            // match dbset count
            var dbSetCount = db.Projects.Count();

            // dbset count should be equal to projects count
            dbSetCount.Should().Be(projects.Count);



            // assert
            //  dbSetCount.Should().BeGreaterThan(0);
        }

        [TestCase("KBGL")]
        public async Task Should_GetJiraProjectByKey(string projectKey)
        {
            string jiraBaseUrl = "https://jira-cloud-demo.atlassian.net/rest/api/2";

            // arrange / act
            RestClientBase<JiraProject> restClient = new RestClientBase<JiraProject>(jiraBaseUrl);

            // get jira projects from api
            var project = await restClient.GetByIdAsync(projectKey);

            // capture json to testcases folder
            var json = JsonConvert.SerializeObject(project, Formatting.Indented);

            string jiraItemJsonFile = $"JiraProject.{projectKey}.json";


            string jiraArtifactFullPath = Testing.TestingDirectory + jiraItemJsonFile;

            var path = Path.Combine(Testing.TestingDirectory(), "TestCases", jiraItemJsonFile);

            // write to file
            await File.WriteAllTextAsync(jiraArtifactFullPath, json);
            //// and store in db, if not present
            //var db = new JiraDbContext();

            //foreach (var project in projects)
            //{
            //    var dbProject = db.Projects.FirstOrDefault(p => p.Key == project.Key);

            //    if (dbProject == null)
            //    {
            //        project.Components.Add("");

            //        // add description, if null or empty
            //        if (string.IsNullOrEmpty(project.Description))
            //        {
            //            project.Description = "No description available.";
            //        }

            //        db.Projects.Add(project);
            //    }
            //}

            //// save changes
            //await db.SaveChangesAsync();

            //// match dbset count
            //var dbSetCount = db.Projects.Count();

            //// dbset count should be equal to projects count
            //dbSetCount.Should().Be(projects.Count);



            // assert
            //  dbSetCount.Should().BeGreaterThan(0);
        }
    }
}