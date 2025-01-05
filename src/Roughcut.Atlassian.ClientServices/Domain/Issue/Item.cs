using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Item : Base
    {
        [JsonProperty("field")] public string Field { get; set; }

        [JsonProperty("fieldtype")] public string Fieldtype { get; set; }

        [JsonProperty("from")] public string From { get; set; }

        [JsonProperty("fromstring")] public string FromString { get; set; }

        [JsonProperty("to")] public string To { get; set; }
    }
}