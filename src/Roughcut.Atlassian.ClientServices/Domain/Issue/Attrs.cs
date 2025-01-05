using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Attrs
    {
        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("level")] public int Level { get; set; }
    }
}