using Newtonsoft.Json;
using Roughcut.Atlassian.ClientServices.Models;
using Roughcut.Atlassian.Interfaces.Helpers;

namespace Roughcut.Atlassian.ClientServices.Dtos
{
    public class IssueUpInsertDto
    {


        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public Update Update { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Fields Fields { get; set; }

        public IssueUpInsertDto()
        {
            
        }


        public static JiraIssueUpInsert FromJson(string json) => JsonConvert.DeserializeObject<JiraIssueUpInsert>(json, Converter.Settings);
        //public static string ToJson(this JiraIssue self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
