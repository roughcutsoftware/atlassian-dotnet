using Newtonsoft.Json;

namespace Roughcut.Atlassian.Integration.Tests.Models.QuickType;

public  class Scope
{
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
    public ScopeProject Project { get; set; }
}