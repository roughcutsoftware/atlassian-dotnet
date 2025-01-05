using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roughcut.Atlassian.Interfaces.AppConfig
{
    public class JiraApiSettings
    {
        //
        public static string PublicSecretForTestingString = "Used-For-Secrets-Testing";

        // get testing property - 
        // todo: move to a testing or base class
        [JsonProperty("PublicSharedSecretForTesting", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicSharedSecretForTesting { get; set; }

        [JsonProperty("JiraBaseUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraBaseUrl { get; set; }

        [JsonProperty("JiraLoginUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraLoginUserName { get; set; }

        [JsonProperty("JiraApiAccessKeyId", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraApiAccessKeyId { get; set; }

        // add db connection string property 
        [JsonProperty("JiraDbConnString", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraDbConnString { get; set; }

        //[JsonProperty("JiraApiSecretKey", NullValueHandling = NullValueHandling.Ignore)]
        //public string JiraApiSecretKey { get; set; }

        public JiraApiSettings() { }
    }
}
