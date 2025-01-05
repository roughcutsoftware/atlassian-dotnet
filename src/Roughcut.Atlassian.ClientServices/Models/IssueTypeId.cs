using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Helpers;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class IssueTypeId
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Id { get; set; }
    }
}