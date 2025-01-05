using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Roughcut.Atlassian.ClientServices.Base;
using Roughcut.Atlassian.ClientServices.Dtos;
using Roughcut.Atlassian.Interfaces.Base;
using Roughcut.Atlassian.Interfaces.Helpers;

namespace Roughcut.Atlassian.ClientServices.Services
{
    public class JiraService<T> : ViewModelBase<T> where T : class  // : IRepositoryAsync<T> where T : class
    {
        //public static JiraService<T> FromJson(string json) => JsonConvert.DeserializeObject<JiraService<T>>(json, Converter.Settings);

        public List<ProjectDto> Projects { get; set; }

        //ViewModelBase<T> _viewModel = new ViewModelBase<T>(ProjectActions.BaseUrl);

        HttpMethodsBase<T> HttpMethods { get; set; }

        //HttpVerbsBase<T> _httpVerbsBase = new HttpVerbsBase<T>(ProjectActions.BaseUrl);

        /// <summary>
        /// To get a User from the RestApi
        /// </summary>
        protected const string AccountId = "";

        protected const string Username = "";

        protected const string Password = "";

        protected const string ProjectKey = "KBGL";

        protected const string IssueKeyToSearch = "KBGL-8";

        //protected readonly JiraRestClient RestClient;

        protected Uri BaseUri;

        public JiraService(string baseUrl) : base(baseUrl)
        {
            //string uri = Environment.GetEnvironmentVariable("JIRA_BASE_URL");
            //if (string.IsNullOrEmpty(uri))
            //{
            //    uri = "https://jira-cloud-demo.atlassian.net/";
            //}

            //Uri = new Uri(uri);

            // https://stackoverflow.com/questions/64179268/jsonobject-attribute
            //var schemaGenerator = new Newtonsoft.Json.Schema.JsonSchemaGenerator();
            //var fooSchema = schemaGenerator.Generate(typeof(Foo)).ToString();
            //var barSchema = schemaGenerator.Generate(typeof(Bar)).ToString();

            // set the base address
            this.HttpMethods = new HttpMethodsBase<T>(baseUrl);

            string username = "houston@roughcutsoftware.com";
            if (string.IsNullOrEmpty(username))
            {
                username = "admin";
            }

            // get the password from the secrets file - this is a security risk
            // move this to a secure location - use Azure Key Vault, AWS Secrets Manager, or GCP Secret Manager
            // secrets.jira-apikey-placeholder.txt is a placeholder file
            string password = File.ReadAllText(@"C:\repos\RoughcutSoftware\atlassian-dotnet\src\Roughcut.Atlassian.ClientServices\.secrets\secrets.jira-rcs.txt");

            // 
            if (string.IsNullOrEmpty(password))
            {
                password = "admin";
            }

            //
            var bytes = Encoding.ASCII.GetBytes(username + ":" + password);
            string Base64Token = Convert.ToBase64String(bytes);

            // todo: add the Accept header
            // this.RestClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            this.RestClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Base64Token);
        }

        // 
        public async Task<List<T>> GetListAsync()
        {
            // initialize the list of T items
            List<T> itemsList = new List<T>();

            // in a try-catch block, get the list of T items using the base class
            try
            {
                // build uri string 
                Uri uri = new Uri(string.Format(HttpMethods.GetList<T>(), string.Empty));

                // make full uri string from uri
                string fullUri = uri.ToString();

                // get list of TodoItemDtos
                itemsList = await base.GetListAsync(fullUri);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            // return
            return itemsList;
        }

        //public async Task<List<T>> GetListAsync(string actionUrl)
        //{
        //    // get list of TodoItemDtos
        //    List<T> projectsList = await base.GetListAsync(ProjectActions.GetItems);
        //    throw new NotImplementedException();
        //}

        public Task<T> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> QueryAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(T entity, bool isNewItem)
        {
            if (entity == null) {
                throw new ArgumentNullException(nameof(entity));
            }
            else
            {
                // use base to create a new item
                await base.AddAsync(entity, isNewItem);
            }

        }

        public Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}