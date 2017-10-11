using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Source;

namespace MixMedia.JointSpace.Manager
{
    public class SourceManager
    {
        private readonly HttpClient client;

        public SourceManager(HttpClient client)
        {
            this.client = client;
        }

        public async Task<SourceList<Source>> GetSources()
        {
            return await client.GetAsync<SourceList<Source>>($"/1/sources");
        }

        public async Task<SimpleSource> GetCurrentSource()
        {
            return await client.GetAsync<SimpleSource>($"/1/sources/current");
        }
        
        public async void SetCurrentSource(string id)
        {
            await client.PostAsync($"/1/sources/current", new SimpleSource { Id = id});
        }
    }
}
