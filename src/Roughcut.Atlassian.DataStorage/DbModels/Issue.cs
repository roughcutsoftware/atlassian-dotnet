using Roughcut.Atlassian.DataStorage.Base;
using Roughcut.Atlassian.DataStorage.Helpers;
using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Jira;

namespace Roughcut.Atlassian.DataStorage.DbModels
{
    [JsonObject("issue", ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Issue : ArtifactBase, IIssue
    {
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("reporter", NullValueHandling = NullValueHandling.Ignore)]
        public string Reporter { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        [JsonProperty("watchers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Watchers { get; set; }

        [JsonProperty("issueType", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueType { get; set; }

        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public string Resolution { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        [JsonProperty("affectedVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AffectedVersions { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public string Assignee { get; set; }

        [JsonProperty("fixedVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FixedVersions { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Components { get; set; }

        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ExternalId { get; set; }

        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public List<History> History { get; set; }

        [JsonProperty("customFieldValues", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomFieldValue> CustomFieldValues { get; set; }

        //[JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        //public List<Attachment> Attachments { get; set; }
    }
}

