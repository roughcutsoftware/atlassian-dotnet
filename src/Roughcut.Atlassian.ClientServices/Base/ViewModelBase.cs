using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Roughcut.Atlassian.Interfaces.Base;
using Roughcut.Atlassian.Interfaces.DataStorage;

namespace Roughcut.Atlassian.ClientServices.Base
{
    public class ViewModelBase<T> : IRepositoryAsync<T> where T : class
    {
        public HttpClient RestClient { get; private set; }

        HttpMethodsBase<T> HttpMethods { get; set; }

        public ViewModelBase(string baseUrl)
        {
            // set the base address
            this.HttpMethods = new HttpMethodsBase<T>(baseUrl);

            //
            HttpClientHandler handler = RestClientHandler();

            this.RestClient = new HttpClient(handler);

            this.RestClient.BaseAddress = new Uri(baseUrl);
        }

        // set up the HttpClientHandler - required for untrusted SSL certificates - to support netstandard2.0
        // https://stackoverflow.com/questions/12553277/allowing-untrusted-ssl-certificates-with-httpclient
        private HttpClientHandler RestClientHandler()
        {
            //ServicePointManager.ServerCertificateValidationCallback += (_, _, _, _) => true;

            //
            var handler = new HttpClientHandler();

            // https://stackoverflow.com/questions/12553277/allowing-untrusted-ssl-certificates-with-httpclient
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;

            // https://stackoverflow.com/questions/12553277/allowing-untrusted-ssl-certificates-with-httpclient
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            //
            return handler;

        }

        public async Task<List<T>> GetListAsync(string actionUrl)
        {
            // new up a list of T
            var list = new List<T>();
            
            try
            {
                //// rebuild the url
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
            //Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            // create uri from HttpVerbs
            Uri uri = new Uri(string.Format(HttpMethods.Create<T>(), string.Empty));

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
                    Debug.WriteLine(@"\tItem successfully saved.");
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
