using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Helpers;

namespace Roughcut.Atlassian.ClientServices.Models
{
    public class Timetracking
    {
        [JsonProperty("originalEstimate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? OriginalEstimate { get; set; }

        [JsonProperty("remainingEstimate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? RemainingEstimate { get; set; }
    }

}