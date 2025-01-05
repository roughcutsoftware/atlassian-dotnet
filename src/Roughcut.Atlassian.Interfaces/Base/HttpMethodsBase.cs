namespace Roughcut.Atlassian.Interfaces.Base
{
    public class HttpMethodsBase<T> where T : class
    {
        //public static string BaseUrl = @"https://jsonplaceholder.typicode.com";

        public string BaseUrl { get; private set; } 
        
        //= @"https://jsonplaceholder.typicode.com";

        //public static string GetTodos = "/todos";
        //public static string GetTodo = "/todos/{0}";

        //public static string PostTodo = "/todos";
        //public static string PutTodo = "/todos/{0}";

        //public static string DeleteTodo = "/todos/{0}";

        public HttpMethodsBase(string baseUrl)
        {
            this.BaseUrl = baseUrl;
        }

        public string GetById<T>(string keyValue)
        {
            // get generic type name
            string typeName = typeof(T).Name;

            // clean string
            typeName = CleanString(typeName);

            string apiActionUrl = BaseUrl + $"/{typeName}/{keyValue}";

            //
            return apiActionUrl;
        }

        public string GetList<T>() //string keyValue = "")
        {
            // get generic type name
            string typeName = typeof(T).Name;

            // clean string
            typeName = CleanString(typeName);

            string apiActionUrl = BaseUrl + $"/{typeName}";


            //
            return apiActionUrl;
        }

        public string Create<T>()
        {
            // get generic type name
            string typeName = typeof(T).Name;

            // clean string
            typeName = CleanString(typeName);

            string apiActionUrl = BaseUrl + $"/{typeName}";

            return apiActionUrl;
        }

        public string Delete<T>(string keyValue)
        {
            // get generic type name
            string typeName = typeof(T).Name.ToLower();

            string apiActionUrl = BaseUrl + $"/{typeName}/{keyValue}";

            //if (!string.IsNullOrEmpty(keyValue))
            //{
            //    apiActionUrl = string.Format(BaseUrl + GetTodo, keyValue);
            //}

            //
            return apiActionUrl;
        }

        // clean string remove jira and dto
        private string CleanString(string typeName)
        {
            return typeName
                .ToLower()
                .Replace("UpInsert".ToLower(), "")
                .Replace("jira", "")
                .Replace("dto", "");
        }

        //static List<T> ProcessItems<T>(List<T> items, Func<T, T> processor)
        //{
        //    List<T> result = new List<T>();
        //    foreach (T item in items)
        //    {
        //        result.Add(processor(item));
        //    }
        //    return result;
        //}

    }
}
