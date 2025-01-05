using System;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class Roles
    {
        [JsonProperty("Developers", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Developers { get; set; }
    }
}