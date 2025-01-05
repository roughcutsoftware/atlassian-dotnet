namespace Roughcut.Atlassian.Interfaces.AppConfig
{
    public class YourClassName
    {
        // derived from below SO-article
        // https://stackoverflow.com/questions/42268265/how-to-get-manage-user-secrets-in-a-net-core-console-application

        // additional reference
        // https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=windows
        // https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-8.0&tabs=windows#user-secrets-in-non-web-applications

        //
        public static string PublicSecretForTestingString = "Used-For-Secrets-Testing";

        public string Secret1 { get; set; }
        public string Secret2 { get; set; }


        //// get JiraApiSettings json from object
        //JiraApiSettings jiraApiSettings = new JiraApiSettings
        //{
        //    JiraBaseUrl = "https://jira-cloud-demo.atlassian.net/",
        //    JiraLoginUserName = "jirauser",
        //    JiraApiAccessKeyId = "jiraapikey"
        //};

        //// serialize object to json
        //string jsonPreview = JsonConvert.SerializeObject(jiraApiSettings);

        //// JiraApiSettings.json / secrets.json
        //string jiraApiSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        //                 + @"\Microsoft\UserSecrets\atlassian-dotnet-user-secrets\JiraApiSettings.json";

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


        //string json = System.IO.File.ReadAllText(jiraApiSettingsPath);

        //JiraApiSettings settings = JsonConvert.DeserializeObject<JiraApiSettings>(json);

        // act

        //JiraApiSettings settings = JsonConvert.DeserializeObject<JiraApiSettings>(json);

        //   Assert.True(true);
        //JiraApiSettings settings = JiraApiSettings.GetJiraApiSettings();
    }
}