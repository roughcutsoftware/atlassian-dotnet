using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{
    public class IssueUpdate
    {
        [JsonProperty("fields")] 
        public IssueFields Fields { get; set; }
        
        [JsonProperty("transition")]
        public Transition Transition { get; set; }
        
        [JsonProperty("historyMetadata")]
        public HistoryMetadata HistoryMetadata { get; set; }
        
        [JsonProperty("properties")]
        public List<EntityProperty> Properties { get; set; }
    }

    public class HistoryMetadata
    {
        [JsonProperty("activityDescription")]
        public string ActivityDescription { get; set; }

        [JsonProperty("activityDescriptionKey")]
        public string ActivityDescriptionKey { get; set; }

        [JsonProperty("actor")]
        public HistoryMetadataParticipant Actor { get; set; }

        [JsonProperty("cause")]
        public HistoryMetadataParticipant Cause { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("descriptionKey")]
        public string DescriptionKey { get; set; }

        [JsonProperty("emailDescription")]
        public string EmailDescription { get; set; }

        [JsonProperty("emailDescriptionKey")]
        public string EmailDescriptionKey { get; set; }

        [JsonProperty("extraData")]
        public ExtraData ExtraData { get; set; }

        [JsonProperty("generator")]
        public HistoryMetadataParticipant Generator { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ExtraData
    {
    }

    public class HistoryMetadataParticipant
    {
        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayNameKey")]
        public string DisplayNameKey { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class EntityProperty
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}