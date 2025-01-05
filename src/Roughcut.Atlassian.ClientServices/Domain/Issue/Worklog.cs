using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Worklog
    {
        [JsonProperty("startat")] public int? StartAt { get; set; }
        [JsonProperty("maxresults")] public int? MaxResults { get; set; }
        [JsonProperty("total")] public int? Total { get; set; }
        [JsonProperty("worklogs")] public List<object> Worklogs { get; set; }
    }
}