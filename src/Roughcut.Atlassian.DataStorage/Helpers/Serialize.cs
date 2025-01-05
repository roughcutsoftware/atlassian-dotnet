using Roughcut.Atlassian.DataStorage.Services;
using Newtonsoft.Json;

namespace Roughcut.Atlassian.DataStorage.Helpers
{
    public static class Serialize
    {
        public static string ToJson(this JiraService self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}