using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class Component :Base
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
