﻿using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Helpers;

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var itsmManageEngine = ItsmManageEngine.FromJson(jsonString);

namespace Roughcut.Atlassian.ClientServices.Models
{


    public class JiraIssueUpInsert
    {
        public static JiraIssueUpInsert FromJson(string json) => JsonConvert.DeserializeObject<JiraIssueUpInsert>(json, Converter.Settings);
        //public static string ToJson(this JiraIssue self) => JsonConvert.SerializeObject(self, Converter.Settings);

        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public Update Update { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Fields Fields { get; set; }
    }
}
