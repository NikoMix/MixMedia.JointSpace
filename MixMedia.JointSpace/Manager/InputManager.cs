using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Requests;

namespace MixMedia.JointSpace.Controller
{
    public class InputManager
    {
        private readonly HttpClient client;
        
        public InputManager(HttpClient client)
        {
            this.client = client;
        }

        public async Task<HttpResponseMessage> SendKey(JointSpaceKeys key)
        {
            return await client.PostAsync($"/1/input/key", new SendKeyRequest() { Key = key });
        }
    }
}
