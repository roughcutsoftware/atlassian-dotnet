using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class Errors
    {
        [JsonProperty("project")]
        public string Project {get;set;}
        [JsonProperty("subtasks")]
        public string Subtasks {get;set;}
        [JsonProperty("attachment")]
        public string Attachment {get;set;}
        [JsonProperty("issuelinks")]
        public string IssueLinks {get;set;}
        [JsonProperty("issuetype")]
        public string IssueType {get;set;}
        [JsonProperty("reporter")]
        public string Reporter {get;set;}
        [JsonProperty("assignee")]
        public string Assignee {get;set;}
        [JsonProperty("environment")]
        public string Environment {get;set;}
        [JsonProperty("filterName")]
        public string FilterName {get;set;}
        [JsonProperty("versions")]
        public string Versions {get;set;}
        [JsonProperty("components")]
        public string Components {get;set;}
        [JsonProperty("email")]
        public string Email {get;set;}
        [JsonProperty("projectType")]
        public string ProjectType {get;set;}
        [JsonProperty("projectKey")]
        public string ProjectKey {get;set;}
        [JsonProperty("projectName")]
        public string ProjectName {get;set;}
    }
}