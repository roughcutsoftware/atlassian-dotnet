using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Jira;

namespace Roughcut.Atlassian.ClientServices.Dtos
{
    public class VersionDto : IVersion
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("released", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Released { get; set; }

        [JsonProperty("releaseDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDate { get; set; }
    }
}