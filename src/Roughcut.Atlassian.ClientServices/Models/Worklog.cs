using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class Worklog
    {
        [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
        public Add Add { get; set; }
    }
}