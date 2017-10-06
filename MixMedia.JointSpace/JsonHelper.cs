using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MixMedia.JointSpace
{
    public static class JsonHelper
    {
        public static async Task<TResponse> GetAsync<TResponse>(this HttpClient client, string requestedUri)
            where TResponse : new()
        {
            var response = await client.GetAsync(requestedUri);
            return await response.As<TResponse>();
        }

        public static async Task<TResponse> DeleteAsync<TResponse>(this HttpClient client, string requestedUri)
            where TResponse : new()
        {
            var response = await client.DeleteAsync(requestedUri);
            return await response.As<TResponse>();
        }

        public static async Task<TResponse> PostAsync<TRequest, TResponse>(this HttpClient client, string requestedUri, TRequest requestObject)
            where TRequest : new()
            where TResponse : new()
        {
            var response = await client.PostAsync(requestedUri, 
                new JsonContent<TRequest>(requestObject));

            return await response.As<TResponse>();
        }

        public static async Task<TResponse> PutAsync<TRequest, TResponse>(this HttpClient client, string requestedUri, TRequest requestObject)
            where TRequest : new()
            where TResponse : new()
        {
            var response = await client.PutAsync(requestedUri,
                new JsonContent<TRequest>(requestObject));

            return await response.As<TResponse>();
        }

        public static async Task<T> As<T>(this HttpResponseMessage response)
        {
            return JsonConvert.DeserializeObject<T>
                (await response.Content.ReadAsStringAsync());
        }
    }
}
