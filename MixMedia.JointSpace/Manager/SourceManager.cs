using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Source;

namespace MixMedia.JointSpace.Manager
{
    public class SourceManager
    {
        private readonly HttpClient _client;

        public SourceManager(HttpClient client)
        {
            _client = client;
        }

        public async Task<SourceList<Source>> GetSources()
        {
            return await _client.GetAsync<SourceList<Source>>($"/1/sources");
        }

        public async Task<string> GetCurrentSource()
        {
            var result = await _client.GetAsync<CurrentObject>($"/1/sources/current");
            return result.Id;
        }
        
        public async void SetCurrentSource(string id)
        {
            await _client.PostAsync($"/1/sources/current", new CurrentObject { Id = id});
        }
    }
}
