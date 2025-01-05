namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class Comment : Base
    {
        public User Author { get; set; }

        public string Body { get; set; }

        public User UpdateAuthor { get; set; }

        public string Created { get; set; }

        public string Updated { get; set; }
    }
}