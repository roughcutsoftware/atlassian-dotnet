using Roughcut.Atlassian.ClientServices.Dtos;
using Roughcut.Atlassian.ClientServices.Services;
using Roughcut.Atlassian.Interfaces.Extensions;
using Bogus;
using FizzWare.NBuilder;
using FluentAssertions;

namespace Roughcut.Atlassian.ClientServices.Tests
{
    public class JiraIssuesServiceTests
    {
        JiraService<IssueDto> _jiraService;

        public JiraIssuesServiceTests() { }

        [SetUp]
        public void Setup()
        {
            string jiraBaseUrl = "https://jira-cloud-demo.atlassian.net/rest/api/2";
            this._jiraService = new JiraService<IssueDto>(jiraBaseUrl);
        }

        [TestCase]
        public async Task Should_CreateJiraArtifact()
        {
            // arrange / act
            //IssueDto issueDto = new IssueDto();

            // create new fake issue
            var issueDto = Builder<IssueDto>
                .CreateNew()
                //.With(x => x = "BANK")
                .With(x => x.Description = "A custom description here")
                .With(x => x.Summary = "Story - Add-Test - " + DateTime.Now.ToString("F"))
                .With(x => x.IssueType = "Story")
                //.With(x => x.)
                .Build();

            //
            await _jiraService.AddAsync(issueDto, true);

            // assert
            //result.Should().NotBeNull();

        }

        // should get attribute property value by name
        //[TestCase]
        //public void Should_GetAttributePropertyValueByName()
        //{
        //    // arrange
        //    string propertyName = "Id";
        //    Project jiraProject = new Project();
            
        //    // act
        //    string propertyValue = jiraProject.GetAttributePropValue(propertyName);

        //    // assert
        //    Assert.IsNotNull(propertyValue);
        //    Assert.AreEqual(propertyName, propertyValue);
        //}
    }
}