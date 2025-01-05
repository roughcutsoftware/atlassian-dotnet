using Roughcut.Atlassian.DataStorage.Base;
using Roughcut.Atlassian.DataStorage.Helpers;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage.DbModels
{

    public class Link : ArtifactBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? SourceId { get; set; }

        [JsonProperty("destinationId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? DestinationId { get; set; }
    }
}