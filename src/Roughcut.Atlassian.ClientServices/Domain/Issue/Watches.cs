using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Watches
    {
        [JsonProperty("self")] public string Self { get; set; }
        [JsonProperty("watchcount")] public int? WatchCount { get; set; }
        [JsonProperty("iswatching")] public bool IsWatching { get; set; }
    }
}