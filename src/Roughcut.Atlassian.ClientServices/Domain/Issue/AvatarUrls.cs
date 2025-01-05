using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class AvatarUrls
    {
        [JsonProperty("16x16")] public string Url16X16 { get; set; }
        [JsonProperty("24x24")] public string Url24X24 { get; set; }
        [JsonProperty("32x32")] public string Url32X32 { get; set; }
        [JsonProperty("48x48")] public string Url48X48 { get; set; }
    }
}