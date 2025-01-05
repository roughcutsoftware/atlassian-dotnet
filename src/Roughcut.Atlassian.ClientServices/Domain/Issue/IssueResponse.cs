using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{
    public class IssueResponse : KeyBase
    {
        [JsonProperty("errorMessages")]
        public List<string> ErrorMessages { get; set; }
        
        [JsonProperty("errors")]
        public Errors Errors { get; set; }
    }
}