using Newtonsoft.Json;

namespace Roughcut.Atlassian.Integration.Tests.Models.QuickType;

public static class Serialize
{
    public static string ToJson(this Models self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
}