using Roughcut.Atlassian.DataStorage.Base;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage.DbModels;

public  class User : ArtifactBase
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
}