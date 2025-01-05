using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Description
    {
        [JsonProperty("version")] public int Version { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("content")] public List<Content> Content { get; set; }
    }
}