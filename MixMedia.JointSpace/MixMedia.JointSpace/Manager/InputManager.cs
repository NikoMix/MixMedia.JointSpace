using System;
using System.Collections.Generic;
using System.Linq;
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

        // TODO: http://ip-address:1925/1/input/key
        // AllowAnnonym
        public async void SendKey(JointSpaceKeys key)
        {
            var model = new SendKeyRequest(){ Key = key};
            await client.PostAsync($"/1/input/key", new StringContent("", Encoding.UTF8));
        }
    }
}
