using Newtonsoft.Json;
using Roughcut.Atlassian.ClientServices.Models;

namespace Roughcut.Atlassian.ClientServices.Models
{

    public static class Serialize
    {
        //public static string ToJson(this ItsmManageEngine self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this JiraIssueUpInsert self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);
    }
}