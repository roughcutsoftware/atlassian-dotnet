using System.Collections.Generic;

namespace Roughcut.Atlassian.ClientServices.Domain.Issue
{

    public class CommentList
    {
        public int? StartAt { get; set; }
        public int? MaxResults { get; set; }
        public int? Total { get; set; }
        public List<Comment> Comments { get; set; }
    }
}