using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class Base
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("self")]
        public string Self { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class KeyBase : Base
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
