using System.Collections.Generic;

namespace Roughcut.Atlassian.Interfaces.Jira
{
    public interface IProject
    {
        string Name { get; set; }
        string Key { get; set; }
        string Description { get; set; }
        List<IVersion> Versions { get; set; }
        List<string> Components { get; set; }
        //List<IssueDto> Issues { get; set; }
    }
}
