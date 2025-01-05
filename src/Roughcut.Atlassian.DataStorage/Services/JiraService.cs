using Roughcut.Atlassian.DataStorage.Helpers;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage.Services
{
    public class JiraService
    {
        public static JiraService FromJson(string json) => JsonConvert.DeserializeObject<JiraService>(json, Converter.Settings);
    }
}