using Newtonsoft.Json;

namespace Roughcut.Atlassian.Integration.Tests.Models.QuickType;

public  class Issuetype
{
    [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
    public Uri Self { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? Id { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)]
    public Uri IconUrl { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("untranslatedName", NullValueHandling = NullValueHandling.Ignore)]
    public string UntranslatedName { get; set; }

    [JsonProperty("subtask", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Subtask { get; set; }

    [JsonProperty("hierarchyLevel", NullValueHandling = NullValueHandling.Ignore)]
    public long? HierarchyLevel { get; set; }

    [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
    public Scope Scope { get; set; }
}