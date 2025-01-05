using Newtonsoft.Json;

namespace Roughcut.Atlassian.Integration.Tests.Models.QuickType;

public  class ScopeProject
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? Id { get; set; }
}