using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class Update
    {
        [JsonProperty("worklog", NullValueHandling = NullValueHandling.Ignore)]
        public List<Worklog> Worklog { get; set; }
    }
}