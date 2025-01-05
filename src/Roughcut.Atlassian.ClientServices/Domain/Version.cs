using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class Version :Base
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("archived")]
        public bool Archived { get; set; }
        [JsonProperty("released")]
        public bool Released { get; set; }
        [JsonProperty("overdue")]
        public bool Overdue { get; set; }
        [JsonProperty("releasedate")]
        public string ReleaseDate { get; set; }
        [JsonProperty("userreleasedate")]
        public string UserReleaseDate { get; set; }
    }
}
