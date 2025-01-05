using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Progress
    {
        [JsonProperty("progress")] public int? ProgressValue { get; set; }
        [JsonProperty("total")] public int? Total { get; set; }
    }
}