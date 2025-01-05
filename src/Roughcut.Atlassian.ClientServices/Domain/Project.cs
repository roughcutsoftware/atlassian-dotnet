using System.Collections.Generic;
using Newtonsoft.Json;
using Roughcut.Atlassian.ClientServices.Domain.Issue;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class Project : KeyBase
    {
        [JsonProperty("expand")]
        public string Expand { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("lead")]
        public User Lead { get; set; }
        [JsonProperty("components")]
        public List<Component> Components { get; set; }
        [JsonProperty("issuetypes")]
        public List<IssueType> IssueTypes { get; set; }
        [JsonProperty("assigneetype")]
        public string AssigneeType { get; set; }
        [JsonProperty("versions")]
        public List<Version> Versions { get; set; }
        [JsonProperty("roles")]
        public Roles Roles { get; set; }
        [JsonProperty("avatarurls")]
        public AvatarUrls AvatarUrls { get; set; }
    }

    public class Roles
    {
        [JsonProperty("users")]
        public string Users { get; set; }
        [JsonProperty("administrators")]
        public string Administrators { get; set; }
        [JsonProperty("developers")]
        public string Developers { get; set; }
    }
}
