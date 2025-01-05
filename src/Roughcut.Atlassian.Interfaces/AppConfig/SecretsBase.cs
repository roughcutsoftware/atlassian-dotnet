using Roughcut.Atlassian.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roughcut.Atlassian.Interfaces.AppConfig
{
    public class SecretsBase : ISecretsBase
    {
        public string Secret1 { get; set; }
        public string Secret2 { get; set; }

        public SecretsBase()
        {
            Secret1 = "Secret1";
        }

        private readonly SecretsBase _secrets;

    }
}
