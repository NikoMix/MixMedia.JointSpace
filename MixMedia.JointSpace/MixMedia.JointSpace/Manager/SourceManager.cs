using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.JointSpace.Manager
{
    public class SourceManager
    {
        private readonly HttpClient client;

        public SourceManager(HttpClient client)
        {
            this.client = client;
        }

        // TODO: http://ip-address:1925/1/sources
        public async void GetSources()
        {
            await client.GetAsync($"/1/sources");
        }

        // TODO: http://ip-address:1925/1/sources/current
        public async Task<string> GetCurrentSource()
        {
            await client.GetAsync($"/1/sources/current");
            return String.Empty;
        }

        // TODO: http://ip-address:1925/1/sources/current
        public async void SetCurrentSource(string id)
        {
            await client.PostAsync($"/1/sources/current", new StringContent(""));
        }
    }
}
