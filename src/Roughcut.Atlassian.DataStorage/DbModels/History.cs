using Roughcut.Atlassian.DataStorage.Base;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage.DbModels
{
    public class History : ArtifactBase
    {
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }
}