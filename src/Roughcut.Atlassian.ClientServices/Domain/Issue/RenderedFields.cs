using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class RenderedFields : Base
    {
        [JsonProperty("aggregatetimeestimate")]
        public string Aggregatetimeestimate { get; set; }

        [JsonProperty("aggregatetimeoriginalestimate")]
        public string Aggregatetimeoriginalestimate { get; set; }

        [JsonProperty("timetracking")] public Timetracking Timetracking { get; set; }

        [JsonProperty("environment")] public string Environment { get; set; }

        [JsonProperty("created")] public string Created { get; set; }

        [JsonProperty("updated")] public string Updated { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("timeestimate")] public string Timeestimate { get; set; }

        [JsonProperty("duedate")] public string Duedate { get; set; }

        [JsonProperty("lastviewed")] public string LastViewed { get; set; }

        [JsonProperty("attachment")] public List<Attachment> Attachment { get; set; }

        [JsonProperty("comment")] public CommentList Comment { get; set; }

        [JsonProperty("timeoriginalestimate")] public string Timeoriginalestimate { get; set; }

        [JsonProperty("timespent")] public object Timespent { get; set; }

        [JsonProperty("worklog")] public Worklog Worklog { get; set; }

        [JsonProperty("aggregatetimespent")] public object Aggregatetimespent { get; set; }
    }
}