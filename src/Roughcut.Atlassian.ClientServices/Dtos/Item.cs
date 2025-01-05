using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Helpers;


namespace Roughcut.Atlassian.ClientServices.Dtos
{
    public  class Item
    {
        [JsonProperty("fieldType", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? From { get; set; }

        [JsonProperty("fromString", NullValueHandling = NullValueHandling.Ignore)]
        public string FromString { get; set; }

        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? To { get; set; }

        [JsonProperty("toString", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemToString { get; set; }
    }
}