using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Requests;

namespace MixMedia.JointSpace.Manager
{
    public class InputManager
    {
        private readonly HttpClient _client;
        
        public InputManager(HttpClient client)
        {
            this._client = client;
        }

        public async Task<HttpResponseMessage> SendKey(JointSpaceKeys key)
        {
            return await _client.PostAsync($"/1/input/key", new SendKeyRequest() { Key = key });
        }
    }
}
