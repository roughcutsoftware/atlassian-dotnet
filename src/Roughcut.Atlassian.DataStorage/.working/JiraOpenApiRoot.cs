using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage
{

    public class JiraOpenApiRoot
    {
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public Components Components { get; set; }

        [JsonProperty("externalDocs", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalDocs ExternalDocs { get; set; }

        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public Info Info { get; set; }

        [JsonProperty("openapi", NullValueHandling = NullValueHandling.Ignore)]
        public string Openapi { get; set; }

        [JsonProperty("paths", NullValueHandling = NullValueHandling.Ignore)]
        public UrlPaths UrlPaths { get; set; }

        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Server> Servers { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        [JsonProperty("x-atlassian-narrative", NullValueHandling = NullValueHandling.Ignore)]
        public XAtlassianNarrative XAtlassianNarrative { get; set; }
    }
}