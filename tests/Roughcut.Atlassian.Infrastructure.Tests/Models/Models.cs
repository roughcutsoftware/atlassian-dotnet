using Newtonsoft.Json;

namespace Roughcut.Atlassian.Integration.Tests.Models.QuickType;

public  class Models
{
    public static Models FromJson(string json) => JsonConvert.DeserializeObject<Models>(json, QuickType.Converter.Settings);

    [JsonProperty("expand", NullValueHandling = NullValueHandling.Ignore)]
    public string Expand { get; set; }

    [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
    public List<ProjectElement> Projects { get; set; }
}