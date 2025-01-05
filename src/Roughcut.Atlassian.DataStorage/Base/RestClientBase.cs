using Roughcut.Atlassian.Interfaces.DataStorage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Roughcut.Atlassian.Interfaces.Base;

namespace Roughcut.Atlassian.DataStorage.Base
{
    public class RestClientBase<T> : IRepositoryAsync<T> where T : class
    {
        public HttpClient RestClient { get; private set; }

        HttpMethodsBase<T> HttpVerbs { get; set; }

        public RestClientBase(string baseUrl)
        {
            
            //ServicePointManager.ServerCertificateValidationCallback += (_, _, _, _) => true;

            // https://stackoverflow.com/questions/12553277/allowing-untrusted-ssl-certificates-with-httpclient
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            
            // set the base address
            this.HttpVerbs = new HttpMethodsBase<T>(baseUrl);

            // setup credentials
            string username = "houston@roughcutsoftware.com";
            if (string.IsNullOrEmpty(username))
            {
                username = "admin";
            }

            string password = File.ReadAllText(@"C:\Users\Houston\OneDrive\.rcsdatastore\secrets.jira-rcs.txt");
            if (string.IsNullOrEmpty(password))
            {
                password = "admin";
            }
            //RestClient = new JiraRestClient(Uri, Username, Password);
            //BaseUri = RestClient.BaseUri;

            var bytes = Encoding.ASCII.GetBytes(username + ":" + password);
            string Base64Token = Convert.ToBase64String(bytes);

            //_viewModel.Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            this.RestClient = new HttpClient(handler);

            this.RestClient.BaseAddress = new Uri(baseUrl);

            this.RestClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Base64Token);
        }

        public async Task<List<T>> GetListAsync(string actionUrl = "")
        {
            actionUrl = this.HttpVerbs.GetList<T>();
            // new up a list of T
            var list = new List<T>();

            try
            {
                // rebuild the url
                //actionUrl = this.RestClient.BaseAddress + actionUrl;

                // get the todos list
                var response = await this.RestClient.GetAsync(actionUrl);

                // check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // get the response content
                    var content = await response.Content.ReadAsStringAsync();

                    //check if the response content is not null
                    if (!string.IsNullOrEmpty(content))
                    {
                        // cast items into a list of items
                        list = JsonConvert.DeserializeObject<List<T>>(content);
                    }
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                throw;
            }


            // return the list
            return list;

        }

        // intentionally not implemented for initial commit - Houston
        public async Task<T> GetByIdAsync(object id)
        {
            // create uri from HttpVerbs
            Uri uri = new Uri(string.Format(HttpVerbs.GetById<T>(id.ToString()), string.Empty));

            // try-catch attempt to get item from rest api by id
            try
            {
                // get the response
                var response = await this.RestClient.GetAsync(uri);

                // check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // get the response content
                    var content = await response.Content.ReadAsStringAsync();

                    // check if the response content is not null
                    if (!string.IsNullOrEmpty(content))
                    {
                        // cast the item into a T
                        var item = JsonConvert.DeserializeObject<T>(content);

                        // return the item
                        return item;
                    }
                }
                else
                {
                    // log the error with detailed message from the response
                    var error = await response.Content.ReadAsStringAsync();

                    // build the error message with the response status code and phrase
                    error = $"Error: {response.StatusCode}, {response.ReasonPhrase}, {error}";

                    Debug.WriteLine(error);

                }
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                throw;
            }

            // return null if the item is not found
            return null;

        }

        public IEnumerable<T> QueryAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(T entity, bool isNewItem)
        {
            //Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            // create uri from HttpVerbs
            Uri uri = new Uri(string.Format(HttpVerbs.Create<T>(), string.Empty));

            try
            {
                // serialize the entity
                var jsonString = JsonConvert.SerializeObject(entity);

                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                    response = await RestClient.PostAsync(uri, content);
                else
                    response = await RestClient.PutAsync(uri, content);

                if (response.IsSuccessStatusCode)
                    Debug.WriteLine(@"\tTodoItem successfully saved.");
                else
                {
                    // log the error with detailed message from the response
                    var error = await response.Content.ReadAsStringAsync();

                    // build the error message with the response status code and phrase
                    error = $"Error: {response.StatusCode}, {response.ReasonPhrase}, {error}";

                    Debug.WriteLine(error);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
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
