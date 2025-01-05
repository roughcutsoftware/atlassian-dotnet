using Roughcut.Atlassian.ClientServices.Dtos;
using Roughcut.Atlassian.ClientServices.Services;
using Roughcut.Atlassian.Interfaces.Extensions;
using FluentAssertions;

namespace Roughcut.Atlassian.ClientServices.Tests.Services
{
    public class JiraProjectServiceTests
    {
        JiraService<ProjectDto> _jiraService;

        public JiraProjectServiceTests() { }

        [SetUp]
        public void Setup()
        {
            string jiraBaseUrl = "https://jira-cloud-demo.atlassian.net/rest/api/2";
            _jiraService = new JiraService<ProjectDto>(jiraBaseUrl);
        }

        [TestCase]
        public async Task Should_GetAllItemsList()
        {
            // arrange / act
            //var result = 

            //
            await _jiraService.GetListAsync();

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