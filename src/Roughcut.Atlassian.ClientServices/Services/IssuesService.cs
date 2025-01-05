using System;
using System.IO;
using Roughcut.Atlassian.Interfaces.TestCases;

namespace Roughcut.Atlassian.ClientServices.Services
{
    public class IssuesService
    {

        public IssuesService()
        {
        }

        // create JiraIssueUpInsert as json for creating a new issue
        public static string CreateIssue()
        {

            //issueUpInsert.Fields.Reporter = new Models.Reporter();

            return "";
        }

        // create test issue from json
        public static string CreateTestIssue()
        {

            string exampleIssueFullPath = Testing.TestingDirectory + "IssueExample.json";
            string json = File.ReadAllText(exampleIssueFullPath);

            return json;
        }

        public void GetIssues()
        {
            throw new NotImplementedException();
        }


    }
}
