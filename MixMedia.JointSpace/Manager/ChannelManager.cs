using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;

namespace MixMedia.JointSpace.Manager
{
    public class ChannelManager
    {
        private readonly HttpClient client;

        public ChannelManager(HttpClient client)
        {
            this.client = client;
        }

        public async Task<ChannelList<ChannelDetails>> GetChannels()
        {
            return await client.GetAsync<ChannelList<ChannelDetails>>($"/1/channels");
        }
        
        public async void GetCurrentChannel()
        {
            await client.GetAsync($"/1/channels/current");
        }
        
        public async void SetCurrentChannel()
        {
            await client.PostAsync($"/1/channels/current", new StringContent(""));
        }
        
        public async void GetChannel(string id)
        {
            await client.GetAsync("/1/channels/{id}");
        }
    }
}
