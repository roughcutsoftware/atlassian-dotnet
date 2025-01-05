using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roughcut.Atlassian.DataStorage
{
    public class JiraExchange
    {
        public static JiraExchange FromJson(string json) => JsonConvert.DeserializeObject<JiraExchange>(json, Converter.Settings)!;
    }

    public static class Serialize
    {
        public static string ToJson(this JiraExchange self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ExtractionTypeConverter.Singleton,
                FormatConverter.Singleton,
                ScopeEnumConverter.Singleton,
                PropertyDefaultConverter.Singleton,
                ExampleUnionConverter.Singleton,
                InEnumConverter.Singleton,
                OAuth2ElementConverter.Singleton,
                PurpleXAtlassianConnectScopeConverter.Singleton,
                SchemeConverter.Singleton,
                StateConverter.Singleton,
                ValueUnionConverter.Singleton,
                XChangeTypeConverter.Singleton,
                FluffyXAtlassianConnectScopeConverter.Singleton,
                The5Bfa70F74Af144F59E121Ce185F15A38Converter.Singleton,
                PurpleTypeConverter.Singleton,
                BodyTypeConverter.Singleton,
                ExampleEnumConverter.Singleton,
                TentacledXAtlassianConnectScopeConverter.Singleton,
                ItemsDefaultUnionConverter.Singleton,
                DefaultEnumConverter.Singleton,
                StickyXAtlassianConnectScopeConverter.Singleton,
                PurplePurpleDefaultConverter.Singleton,
                StatusDescriptionConverter.Singleton,
                StatusCategoryConverter.Singleton,
                TransitionTypeConverter.Singleton,
                ScopeUnionConverter.Singleton,
                FluffyDefaultConverter.Singleton,
                FluffyPurpleDefaultConverter.Singleton,
                The200DescriptionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
