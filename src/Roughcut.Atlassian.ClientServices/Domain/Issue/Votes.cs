using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Votes
    {
        [JsonProperty("self")] public string Self { get; set; }
        [JsonProperty("votes")] public int? Vote { get; set; }
        [JsonProperty("hasvoted")] public bool HasVoted { get; set; }
    }
}