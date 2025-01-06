using System;
using System.IO;
using Roughcut.Atlassian.ClientServices.Dtos;
using Roughcut.Atlassian.ClientServices.Models;
using Roughcut.Atlassian.Interfaces.TestCases;

namespace Roughcut.Atlassian.ClientServices.Services
{
    public class JiraIssueService
    {

        public JiraIssueService()
        {
        }

        // create JiraIssueUpInsert as json for creating a new issue
        public IssueUpInsertDto CreateIssue(IssueDto issueDto,  long issueTypeId = 10003)
        {

            //issueUpInsert.Fields.Reporter = new Models.Reporter();

            IssueUpInsertDto issueUpInsert = new IssueUpInsertDto();

            //issueUpInsert.Fields.Summary = "Story - CG-PoC-Testing-Ignore: " + DateTime.Now.ToString("F");

            // initialize the fields
            issueUpInsert.Fields = new Fields("Story - CG-PoC-Testing-Ignore: " + DateTime.Now.ToString("F"));

            //issueUpInsert.Fields.Summary = "something's wrong";
            issueUpInsert.Fields.Assignee = new Assignee("Houston");
            //issueUpInsert.Fields.Reporter = new Assignee("Houston");

            issueUpInsert.Fields.Project.Id = 10002;

            issueUpInsert.Fields.IssueType.Id = issueTypeId;

            issueUpInsert.Fields.Description = issueDto.Description; // "A custom description here";

            issueUpInsert.Fields.Priority.Id = 3;

            //
            return issueUpInsert;
        }

        // create test issue from json
        public static string CreateTestIssue()
        {

            string exampleIssueFullPath = Testing.TestingDirectory() + "IssueExample.json";
            string json = File.ReadAllText(exampleIssueFullPath);

            return json;
        }

        public void GetIssues()
        {
            throw new NotImplementedException();
        }


    }
}
