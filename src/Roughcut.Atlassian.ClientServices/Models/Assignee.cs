using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class Assignee
    {
        public Assignee(string nameInJira)
        {
            this.Name = nameInJira;

        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}