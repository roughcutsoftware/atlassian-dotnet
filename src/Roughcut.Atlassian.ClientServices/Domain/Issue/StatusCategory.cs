using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class StatusCategory : KeyBase
    {
        [JsonProperty("colorname")] public string ColorName { get; set; }
    }
}