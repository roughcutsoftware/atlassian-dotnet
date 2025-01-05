using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{
    public class IssueType : Base
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("iconurl")]
        public string IconUrl { get; set; }
        [JsonProperty("subtask")]
        public bool Subtask { get; set; }
    }
}
