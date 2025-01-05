using System;
using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Helpers;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class Component
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public Lead Lead { get; set; }

        [JsonProperty("assigneeType", NullValueHandling = NullValueHandling.Ignore)]
        public string AssigneeType { get; set; }

        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public Lead Assignee { get; set; }

        [JsonProperty("realAssigneeType", NullValueHandling = NullValueHandling.Ignore)]
        public string RealAssigneeType { get; set; }

        [JsonProperty("realAssignee", NullValueHandling = NullValueHandling.Ignore)]
        public Lead RealAssignee { get; set; }

        [JsonProperty("isAssigneeTypeValid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAssigneeTypeValid { get; set; }

        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public string Project { get; set; }

        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProjectId { get; set; }
    }
}