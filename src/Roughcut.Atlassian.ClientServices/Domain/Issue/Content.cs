using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Content
    {
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("content")] public List<Content> Contents { get; set; }
        [JsonProperty("text")] public string Text { get; set; }
        [JsonProperty("attrs")] public Attrs Attrs { get; set; }
    }
}