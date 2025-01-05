using System.Collections.Generic;
using Newtonsoft.Json;
using Roughcut.Atlassian.ClientServices.Models;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class Fields
    {

        public Fields(string summary)
        {
            // initialize all IssueTypeId properties
            Project = new IssueTypeId();
            IssueType = new IssueTypeId();
            //Assignee = new Assignee();
            //Reporter = new Assignee();
            Priority = new IssueTypeId();
            Labels = new List<string>();
            //Timetracking = new Timetracking();
            //Security = new IssueTypeId();
            //Versions = new List<IssueTypeId>();
            //FixVersions = new List<IssueTypeId>();

            // set the summary
            Summary = summary;

            // set the default values
            //Environment = string.Empty;
            Description = string.Empty;

            // set the default values
            //Duedate = null;


        }



        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public IssueTypeId Project { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [JsonProperty("issuetype", NullValueHandling = NullValueHandling.Ignore)]
        public IssueTypeId IssueType { get; set; }

        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public Assignee Assignee { get; set; }

        //[JsonProperty("reporter", NullValueHandling = NullValueHandling.Ignore)]
        //public Assignee Reporter { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public IssueTypeId Priority { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        //[JsonProperty("timetracking", NullValueHandling = NullValueHandling.Ignore)]
        //public Timetracking Timetracking { get; set; }

        //[JsonProperty("security", NullValueHandling = NullValueHandling.Ignore)]
        //public IssueTypeId Security { get; set; }

        //[JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        //public List<IssueTypeId> Versions { get; set; }

        //[JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        //public string Environment { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        //[JsonProperty("duedate", NullValueHandling = NullValueHandling.Ignore)]
        //public DateTimeOffset? Duedate { get; set; }

        //[JsonProperty("fixVersions", NullValueHandling = NullValueHandling.Ignore)]
        //public List<IssueTypeId> FixVersions { get; set; }
    }
}