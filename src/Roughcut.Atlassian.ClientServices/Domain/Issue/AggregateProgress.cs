using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class AggregateProgress
    {
        [JsonProperty("progress")] public int? Progress { get; set; }
        [JsonProperty("total")] public int? Total { get; set; }
    }
}