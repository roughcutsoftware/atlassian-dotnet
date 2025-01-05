using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Dtos
{
    public  class User
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}