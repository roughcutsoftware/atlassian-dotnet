using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class Permission : KeyBase
    {
        [JsonProperty("type")]
        public string Type { get; set; }
            
        [JsonProperty("description")]
        public string Description{ get; set; }
        
        [JsonProperty("havePermission")]
        public bool HavePermission { get; set; }
            
        [JsonProperty("deprecatedKey")]
        public bool DeprecatedKey { get; set; }
    }
}