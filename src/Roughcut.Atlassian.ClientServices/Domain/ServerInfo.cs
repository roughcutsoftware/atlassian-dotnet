using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class ServerInfo
    {
        [JsonProperty("baseurl")]
        public string BaseUrl { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("versionnumbers")]
        public IList<int> VersionNumbers { get; set; }
        [JsonProperty("buildnumber")]
        public int BuildNumber { get; set; }
        [JsonProperty("builddate")]
        public string BuildDate { get; set; }
        [JsonProperty("servertime")]
        public string ServerTime { get; set; }
        [JsonProperty("scminfo")]
        public string ScmInfo { get; set; }
        [JsonProperty("servertitle")]
        public string ServerTitle { get; set; }
    }
}
