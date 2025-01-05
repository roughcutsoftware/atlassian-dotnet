using System;
using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.AppConfig;

namespace Roughcut.Atlassian.Interfaces.Services
{
    public class SecretsService_Refactor
    {
        public JiraApiSettings JiraApiSettings { get; set; }

        public SecretsService_Refactor()
        {
            JiraApiSettings = new JiraApiSettings();
        }
        public static JiraApiSettings GetJiraApiSettings()
        {
            // get user secrets file from environment variable
            //string filePath = Environment.GetEnvironmentVariable("JIRA_API_SETTINGS_FILE");

            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                             + @"\Microsoft\UserSecrets\atlassian-dotnet-user-secrets\secrets.json";

            //// secrets.json
            //// Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

            //// get user secrets file from environment variable
            //// %APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json
            //string userSecretsDirectory = Environment.GetEnvironmentVariable("USER_SECRETS_DIRECTORY");

            //IConfiguration config = new ConfigurationBuilder()
            //    .SetBasePath(appData)
            //    .AddUserSecrets<JiraApiSettings>()
            //    .Build();

            //string githubToken = config.GetSection("JiraApiSettings").Value;


            string json = System.IO.File.ReadAllText(appData);

            JiraApiSettings settings = JsonConvert.DeserializeObject<JiraApiSettings>(json);

            //
            return settings;

        }
    }
}
