using Bogus.Bson;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Roughcut.Atlassian.Interfaces.AppConfig;
using Roughcut.Atlassian.Interfaces.Services;
//using SecretsService = Roughcut.Atlassian.Interfaces.Services.SecretsService;

namespace Roughcut.Atlassian.ClientServices.Tests.Helpers
{
    public class SecretsServiceTests
    {
        [TestCase("Used-For-Secrets-Testing")]
        public async Task Should_GetSecretFromStoredLocation(string secretStringToTest)
        {
            // arrange / act
            SecretsService secretsService = new SecretsService();

            // get user secrets from secrets.json
            JiraApiSettings jiraApiSettings = await secretsService.GetSecretsAsync<JiraApiSettings>();

            // assert
            jiraApiSettings.PublicSharedSecretForTesting.Should().Be(secretStringToTest);





        }
    }

}
