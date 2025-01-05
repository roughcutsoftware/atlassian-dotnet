using System.Collections.Generic;

namespace Roughcut.Atlassian.Interfaces.Jira
{
    public interface IIssue
    {
        string Priority { get; set; }
        string Description { get; set; }
        string Status { get; set; }
        string Reporter { get; set; }
        List<string> Labels { get; set; }
        List<string> Watchers { get; set; }
        string IssueType { get; set; }
        string Resolution { get; set; }
        string Created { get; set; }
        string Updated { get; set; }
        List<string> AffectedVersions { get; set; }
        string Summary { get; set; }
        string Assignee { get; set; }
        List<string> FixedVersions { get; set; }
        List<string> Components { get; set; }
        long? ExternalId { get; set; }
        //List<History> History { get; set; }
        //List<CustomFieldValue> CustomFieldValues { get; set; }
        //List<Attachment> Attachments { get; set; }
    }
}