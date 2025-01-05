
using FluentAssertions;
using Roughcut.Atlassian.DataStorage.DbContexts;

namespace Roughcut.Atlassian.Integration.Tests.DataStorage
{
    public class JiraDbContextTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_VerifyDbModelsAreUsable()
        {

            // arrange / act
            var db = new JiraDbContext();

            // get count of dbsets
            var dbSetCount = db.Projects.Count();

            // assert
            dbSetCount.Should().BeGreaterThan(0);
        }
    }
}