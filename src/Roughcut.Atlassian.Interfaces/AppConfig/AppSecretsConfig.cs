using Roughcut.Atlassian.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roughcut.Atlassian.Interfaces.AppConfig
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v13.0.3.0)")]
    public class AppSecretsConfig
    {
        [Newtonsoft.Json.JsonProperty("SecretsBase", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SecretsBase SecretsBase { get; set; }

        [Newtonsoft.Json.JsonProperty("JiraApiSettings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public JiraApiSettings JiraApiSettings { get; set; }

        // create property ConnectionStrings
        [Newtonsoft.Json.JsonProperty("ConnectionStrings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ConnectionStrings ConnectionStrings { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }


        //    private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        //    [Newtonsoft.Json.JsonExtensionData]
        //    public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        //    {
        //        get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
        //        set { _additionalProperties = value; }
        //    }
    }
}
