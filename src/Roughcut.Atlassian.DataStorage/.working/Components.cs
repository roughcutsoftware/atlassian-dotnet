using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage;

public class Components
{
    [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, SchemaValue> Schemas { get; set; }

    [JsonProperty("securitySchemes", NullValueHandling = NullValueHandling.Ignore)]
    public SecuritySchemes SecuritySchemes { get; set; }
}