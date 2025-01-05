using System;
using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Helpers;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public class IssueType
    {
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Self { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri IconUrl { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("subtask", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subtask { get; set; }

        [JsonProperty("avatarId", NullValueHandling = NullValueHandling.Ignore)]
        public long? AvatarId { get; set; }
    }
}