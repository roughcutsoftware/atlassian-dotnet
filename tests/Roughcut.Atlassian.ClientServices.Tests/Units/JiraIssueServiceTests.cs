using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roughcut.Atlassian.ClientServices.Dtos;
using Roughcut.Atlassian.ClientServices.Models;
using Roughcut.Atlassian.ClientServices.Services;
using FizzWare.NBuilder;
using FluentAssertions;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Tests.Units
{
    public class JiraIssueServiceTests
    {
        public JiraIssueServiceTests() { }

        [TestCase("KBGL", 10003)]
        public async Task Should_CreateNewIssueForProject(string projectKey, long issueTypeId)
        {
            // arrange / act
            IssueUpInsertDto issueUpInsert = new IssueUpInsertDto();

            issueUpInsert.Fields = new Fields("Story - TESTING-IGNORE: " + DateTime.Now.ToString("F"));

            //issueUpInsert.Fields.Summary = "something's wrong";
            issueUpInsert.Fields.Assignee = new Assignee("Houston");
            //issueUpInsert.Fields.Reporter = new Assignee("Houston");

            issueUpInsert.Fields.Project.Id = 10002;

            issueUpInsert.Fields.IssueType.Id = issueTypeId;

            issueUpInsert.Fields.Description = "A custom description here";

            issueUpInsert.Fields.Priority.Id = 3;

            // submit using viewmodel create
            string jiraBaseUrl = "https://jira-cloud-demo.atlassian.net/rest/api/2";
            var jiraService = new JiraService<IssueUpInsertDto>(jiraBaseUrl);

            // submit
            await jiraService.AddAsync(issueUpInsert, true);











            //var issueDto = Builder<IssueDto>
            //    .CreateNew()
            //    .With(x => x.Description = "A custom description here")
            //    .With(x => x.Summary = "Story - Add-Test - " + DateTime.Now.ToString("F"))
            //    .With(x => x.IssueType = "Story")
            //    .Build();



        }

        [TestCase("KBGL")]
        public async Task Should_GetPriorities(string projectKey)
        {
            // arrange / act
            string jiraBaseUrl = "https://jira-cloud-demo.atlassian.net/rest/api/2";
            var jiraService = new JiraService<PriorityDto>(jiraBaseUrl);

            // get issues for project
            var issues = await jiraService.GetListAsync();

            // assert
            issues.Should().NotBeNull();
        }
    }


}
