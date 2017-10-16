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
            response.EnsureSuccessStatusCode();
            var content = response.Content.ReadAsStringAsync();
            return await response.As<TResponse>();
        }

        public static async Task<TResponse> DeleteAsync<TResponse>(this HttpClient client, string requestedUri)
            where TResponse : new()
        {
            var response = await client.DeleteAsync(requestedUri);
            response.EnsureSuccessStatusCode();
            return await response.As<TResponse>();
        }

        public static async Task<TResponse> PostAsync<TRequest, TResponse>(this HttpClient client, string requestedUri, TRequest requestObject)
            where TRequest : new()
            where TResponse : new()
        {
            var response = await client.PostAsync(requestedUri,
                AsStringContent(requestObject));
            response.EnsureSuccessStatusCode();
            return await response.As<TResponse>();
        }

        public static async Task<HttpResponseMessage> PostAsync<TRequest>(this HttpClient client, string requestedUri, TRequest requestObject)
            where TRequest : new()
        {
            return await client.PostAsync(requestedUri,
              AsStringContent(requestObject));
        }

        public static async Task<TResponse> PutAsync<TRequest, TResponse>(this HttpClient client, string requestedUri, TRequest requestObject)
            where TRequest : new()
            where TResponse : new()
        {
            var response = await client.PutAsync(requestedUri,
                AsStringContent<TRequest>(requestObject));
            response.EnsureSuccessStatusCode();
            return await response.As<TResponse>();
        }

        public static StringContent AsStringContent<T>(this T obj)
        {
            return new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8);
        }

        public static async Task<T> As<T>(this HttpResponseMessage response)
        {
            return JsonConvert.DeserializeObject<T>
                (await response.Content.ReadAsStringAsync());
        }
    }
}
