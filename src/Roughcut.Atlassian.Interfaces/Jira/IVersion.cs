namespace Roughcut.Atlassian.Interfaces.Jira
{
    public interface IVersion
    {
        string Name { get; set; }
        bool? Released { get; set; }
        string ReleaseDate { get; set; }
    }

}