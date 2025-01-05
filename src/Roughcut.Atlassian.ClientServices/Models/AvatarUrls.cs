using System;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class AvatarUrls
    {
        [JsonProperty("48x48", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The48X48 { get; set; }

        [JsonProperty("24x24", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The24X24 { get; set; }

        [JsonProperty("16x16", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The16X16 { get; set; }

        [JsonProperty("32x32", NullValueHandling = NullValueHandling.Ignore)]
        public Uri The32X32 { get; set; }
    }
}