using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Status : Base
    {
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("iconurl")] public string IconUrl { get; set; }
        [JsonProperty("statuscategory")] public StatusCategory StatusCategory { get; set; }
        [JsonProperty("statusColor")] public string StatusColor { get; set; }
    }
}