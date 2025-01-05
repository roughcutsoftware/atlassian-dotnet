namespace Roughcut.Atlassian.ClientServices.Actions
{
    public class TodoActions
    {
        public static string BaseUrl = @"https://jira-cloud-demo.atlassian.net/rest/api/2";

        public static string GetItems = "/project";
        public static string GetTodo = "/project/{0}";

        public static string PostTodo = "/project";
        public static string PutTodo = "/project/{0}";

        public static string DeleteTodo = "/project/{0}";


    }
}