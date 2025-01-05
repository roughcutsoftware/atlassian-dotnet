using System.Collections.Generic;
using Newtonsoft.Json;
using Roughcut.Atlassian.ClientServices.Domain.Issue;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class User : KeyBase
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
        
        [JsonProperty("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }
        
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        
        [JsonProperty("active")]
        public bool Active { get; set; }
        
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
        
        [JsonProperty("groups")]
        public Groups Groups { get; set; }
        
        [JsonProperty("expand")]
        public string Expand { get; set; }
    }

    public class Groups
    {
        [JsonProperty("size")]
        public int Size { get; set; }
        
        [JsonProperty("items")]
        public IList<Group> Items { get; set; }
    }

    public class Group :Base
    {

    }

    public class UserMigration
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
    }
}
