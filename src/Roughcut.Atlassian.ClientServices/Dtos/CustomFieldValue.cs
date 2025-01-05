using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Helpers;


namespace Roughcut.Atlassian.ClientServices.Dtos
{
    public  class CustomFieldValue
    {
        [JsonProperty("fieldName", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        [JsonProperty("fieldType", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Value { get; set; }
    }
}