using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{
    public class IssueBase : KeyBase
    {
        [JsonProperty("expand")]
        public string Expand { get; set; }

        [JsonProperty("fields")]
        public IssueFields Fields { get; set; }

        [JsonProperty("renderedFields")]
        public RenderedFields RenderedFields { get; set; }
        
        [JsonProperty("transitions")]
        public List<Transition> Transitions { get; set; }

        [JsonProperty("changelog")]
        public ChangeLog Changelog { get; set; }
    }
}