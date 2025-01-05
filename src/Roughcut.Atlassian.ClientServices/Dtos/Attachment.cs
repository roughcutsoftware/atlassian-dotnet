using System;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Dtos
{
    public class Attachment
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("attacher", NullValueHandling = NullValueHandling.Ignore)]
        public string Attacher { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Uri { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}