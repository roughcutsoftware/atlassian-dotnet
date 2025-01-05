using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Roughcut.Atlassian.ClientServices.Base;
using Roughcut.Atlassian.Interfaces.AppConfig;

namespace Roughcut.Atlassian.ClientServices.Tests.Base
{
    public class TestingBase
    {
        public TestingBase()
        {
            //// https://stackoverflow.com/questions/42268265/how-to-get-manage-user-secrets-in-a-net-core-console-application
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //    .AddUserSecrets<SecretsBase>()
            //    .AddEnvironmentVariables();

            //var services = new ServiceCollection()
            //    .Configure<SecretsBase>(Configuration.GetSection(nameof(SecretsBase)))
            //    .AddOptions()
            //    .BuildServiceProvider();

            //var SecretID = builder.GetSection("SecretID").Value;
            //var SecretPwd = builder.GetSection("SecretPwd").Value;
        }
        private readonly SecretsBase _secrets;

        public TestingBase(IOptions<SecretsBase> secrets)
        {
            _secrets = secrets.Value;
        }

    }
}
