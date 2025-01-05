using System;
using System.Collections.Generic;
using System.Text;

namespace Roughcut.Atlassian.Interfaces.AppConfig
{
    public class ConnectionStrings //: DbConnectionStringBuilder
    {

        //
        public static string JiraDbConnString { get; set; }

        public string DefaultConnection { get; set; }

        public ConnectionStrings() { }
    }
}
