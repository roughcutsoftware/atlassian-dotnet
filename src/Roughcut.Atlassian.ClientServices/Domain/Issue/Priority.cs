using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Priority : Base
    {
        [JsonProperty("iconurl")] public string IconUrl { get; set; }
    }
}