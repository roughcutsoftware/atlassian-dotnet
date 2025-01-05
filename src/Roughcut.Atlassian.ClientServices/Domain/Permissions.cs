using Newtonsoft.Json;

namespace Roughcut.Atlassian.ClientServices.Domain
{
    public class Permissions : Base
    {
        [JsonProperty("permissions")]
       public PermissionsList PermissionsList { get; set; }
    }

    public class PermissionsList
    {
        [JsonProperty("CREATE_ISSUES")]
        public Permission CreateIssue { get; set; }

        [JsonProperty("EDIT_ISSUE")]
        public Permission EditIssue { get; set; }
    }
}