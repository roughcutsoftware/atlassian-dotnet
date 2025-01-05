using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class IssueFields
    {
        [JsonProperty("parent")] public IssueBase Parent { get; set; }

        [JsonProperty("summary")] public string Summary { get; set; }
        [JsonProperty("progress")] public Progress Progress { get; set; }
        [JsonProperty("timetracking")] public Timetracking Timetracking { get; set; }
        [JsonProperty("issuetype")] public IssueType Issuetype { get; set; }
        [JsonProperty("votes")] public Votes Votes { get; set; }
        [JsonProperty("resolution")] public Resolution Resolution { get; set; }
        [JsonProperty("fixversions")] public List<Version> FixVersions { get; set; }
        [JsonProperty("resolutiondate")] public string Resolutiondate { get; set; }
        [JsonProperty("timespent")] public int? Timespent { get; set; }
        [JsonProperty("creator")] public User Creator { get; set; }
        [JsonProperty("reporter")] public User Reporter { get; set; }

        [JsonProperty("aggregatetimeoriginalestimate")]
        public int? Aggregatetimeoriginalestimate { get; set; }

        [JsonProperty("created")] public string Created { get; set; }
        [JsonProperty("updated")] public string Updated { get; set; }
        [JsonProperty("description")] public Description Description { get; set; }
        [JsonProperty("priority")] public Priority Priority { get; set; }
        [JsonProperty("duedate")] public string Duedate { get; set; }
        [JsonProperty("issuelinks")] public List<object> Issuelinks { get; set; }
        [JsonProperty("watches")] public Watches Watches { get; set; }
        [JsonProperty("worklog")] public Worklog Worklog { get; set; }
        [JsonProperty("subtasks")] public List<object> Subtasks { get; set; }
        [JsonProperty("status")] public Status Status { get; set; }
        [JsonProperty("labels")] public List<string> Labels { get; set; }
        [JsonProperty("workratio")] public int? Workratio { get; set; }
        [JsonProperty("assignee")] public User Assignee { get; set; }
        [JsonProperty("attachment")] public List<Attachment> Attachment { get; set; }

        [JsonProperty("aggregatetimeestimate")]
        public int? Aggregatetimeestimate { get; set; }

        [JsonProperty("project")] public Project Project { get; set; }
        [JsonProperty("versions")] public List<Version> Versions { get; set; }
        [JsonProperty("environment")] public string Environment { get; set; }
        [JsonProperty("timestimate")] public int? Timeestimate { get; set; }
        [JsonProperty("aggregateprogress")] public AggregateProgress AggregateProgress { get; set; }
        [JsonProperty("lastviewed")] public string LastViewed { get; set; }
        [JsonProperty("components")] public List<Component> Components { get; set; }
        [JsonProperty("comment")] public CommentList CommentList { get; set; }
        [JsonProperty("timeoriginalestimate")] public int? Timeoriginalestimate { get; set; }
        [JsonProperty("aggregatetimespent")] public int? Aggregatetimespent { get; set; }
    }
}