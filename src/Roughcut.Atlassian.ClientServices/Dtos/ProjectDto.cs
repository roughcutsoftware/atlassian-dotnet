using System.Collections.Generic;
using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Jira;

namespace Roughcut.Atlassian.ClientServices.Dtos
{

    [JsonObject("project", ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ProjectDto : IProject
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<IVersion> Versions { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Components { get; set; }

        [JsonProperty("issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueDto> Issues { get; set; }

        //public string GetPropertyValueByName(string propertyName)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}