using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class Add
    {
        [JsonProperty("timeSpent", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeSpent { get; set; }

        [JsonProperty("started", NullValueHandling = NullValueHandling.Ignore)]
        public string Started { get; set; }
    }
}