using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Helpers;


namespace Roughcut.Atlassian.ClientServices.Dtos
{
    public  class Link
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