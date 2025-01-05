using Roughcut.Atlassian.ClientServices.Dtos;
using Roughcut.Atlassian.ClientServices.Services;
using Roughcut.Atlassian.Interfaces.Extensions;
using FluentAssertions;

namespace Roughcut.Atlassian.ClientServices.Tests
{
    public class JiraUserServiceTests
    {
        JiraService<User> _jiraService;

        public JiraUserServiceTests() { }

        [SetUp]
        public void Setup()
        {
            string jiraBaseUrl = "https://jira-cloud-demo.atlassian.net/rest/api/2";
            this._jiraService = new JiraService<User>(jiraBaseUrl);
        }

        [TestCase]
        public async Task Should_CreateUserInOrganization()
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