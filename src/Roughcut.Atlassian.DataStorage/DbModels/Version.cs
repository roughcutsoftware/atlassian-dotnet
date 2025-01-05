using Roughcut.Atlassian.DataStorage.Base;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage.DbModels
{
    public class Version : ArtifactBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("released", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Released { get; set; }

        [JsonProperty("releaseDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDate { get; set; }
    }
}