using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;
using Roughcut.Atlassian.Interfaces.DataStorage;

namespace Roughcut.Atlassian.ClientServices.Services
{
    public class RestService<T> : IRepositoryAsync<T> where T : class
    {
        HttpClient _client;


        public List<T> Items { get; private set; }

        public RestService()
        {
            //
            Items = new List<T>();

            // todo: 010 - change to use HttpClientFactory
            // IHttpClientFactory _clientFactory = new HttpClientFactory();
            // _client = _clientFactory.CreateClient();
            //_client = _clientFactory.CreateClient();
            _client = new HttpClient();


        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetListAsync(string actionUrl)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetListAsync()
        {
            Items = new List<T>();

            //Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            //try
            //{
            //    HttpResponseMessage response = await _client.GetAsync(uri);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string content = await response.Content.ReadAsStringAsync();
            //        Items = JsonSerializer.Deserialize<List<T>>(content, _serializerOptions) ?? new List<T>();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(@"\tERROR {0}", ex.Message);
            //}

            return Items;
        }

        public IEnumerable<T> QueryAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(T item, bool isNewItem = false)
        {
            //Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            //try
            //{
            //    string json = JsonSerializer.Serialize(item, _serializerOptions);
            //    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            //    HttpResponseMessage response = null;
            //    if (isNewItem)
            //        response = await _client.PostAsync(uri, content);
            //    else
            //        response = await _client.PutAsync(uri, content);

            //    if (response.IsSuccessStatusCode)
            //        Debug.WriteLine(@"\tTodoItem successfully saved.");
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(@"\tERROR {0}", ex.Message);
            //}
        }

        public Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(string id)
        {
            //Uri uri = new Uri(string.Format(Constants.RestUrl, id));

            //try
            //{
            //    HttpResponseMessage response = await _client.DeleteAsync(uri);
            //    if (response.IsSuccessStatusCode)
            //        Debug.WriteLine(@"\tTodoItem successfully deleted.");
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(@"\tERROR {0}", ex.Message);
            //}
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }


        //public async Task<List<TodoItem>> RefreshDataAsync()
        //{
        //    Items = new List<T>();

        //    Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            Items = JsonSerializer.Deserialize<List<TodoItem>>(content, _serializerOptions);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items;
        //}
    }
}
