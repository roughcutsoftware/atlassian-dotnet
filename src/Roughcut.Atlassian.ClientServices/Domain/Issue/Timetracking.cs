using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Timetracking
    {
        [JsonProperty("originalestimate")] public string OriginalEstimate { get; set; }

        [JsonProperty("originalestimateseconds")]
        public int? OriginalEstimateSeconds { get; set; }
    }
}