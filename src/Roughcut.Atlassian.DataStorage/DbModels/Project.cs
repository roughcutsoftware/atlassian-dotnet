using Roughcut.Atlassian.DataStorage.Base;
using Roughcut.Atlassian.Interfaces;
using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Jira;

namespace Roughcut.Atlassian.DataStorage.DbModels
{
    [JsonObject("project", ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Project : ArtifactBase //, IProject
    {
        // quick fix for the time being
        public Project()
        {
            this.Components = new List<string>();
        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Version> Versions { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Components { get; set; }

        [JsonProperty("issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<Issue> Issues { get; set; }
    }
}