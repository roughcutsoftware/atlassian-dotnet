using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class ChangeLog : Base
    {
        [JsonProperty("startat")] public int StartAt { get; set; }

        [JsonProperty("maxresults")] public int MaxResults { get; set; }

        [JsonProperty("total")] public int Total { get; set; }

        [JsonProperty("histories")] public List<History> Histories { get; set; }
    }
}