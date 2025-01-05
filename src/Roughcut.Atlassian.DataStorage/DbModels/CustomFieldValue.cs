using Roughcut.Atlassian.DataStorage.Base;
using Roughcut.Atlassian.DataStorage.Helpers;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage.DbModels;

public  class CustomFieldValue : ArtifactBase
{
    [JsonProperty("fieldName", NullValueHandling = NullValueHandling.Ignore)]
    public string FieldName { get; set; }

    [JsonProperty("fieldType", NullValueHandling = NullValueHandling.Ignore)]
    public string FieldType { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? Value { get; set; }
}