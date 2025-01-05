using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Roughcut.Atlassian.Interfaces.AppConfig;

namespace Roughcut.Atlassian.Interfaces.Services
{
    public class SecretsService
    {
        private readonly IConfigurationRoot config;

        public SecretsService()
        {
            //
            this.config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<AppSecretsConfig>()
                .Build();

        }


        // keep as 'async' to allow for future async operations
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<T> GetSecretsAsync<T>()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            // get type name
            var typeName = typeof(T).Name;

            // get appsecret section from configuration
            // must use/include binder package to bind to the object via Get<T>
            // https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Binder/
            var appSecrets = config.GetSection(typeName).Get<T>();

            // example of getting a specific section
            // var jiraApiSettings = config.GetSection("JiraApiSettings").Get<JiraApiSettings>();

            //
            return appSecrets;
        }
    }
}
