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

        // TODO: http://ip-address:1925/1/channels
        public async Task<ChannelList> GetChannels()
        {
            await client.GetAsync($"/1/channels");
            return new ChannelList();
        }

        // TODO: http://ip-address:1925/1/channels/current
        public async void GetCurrentChannel()
        {
            await client.GetAsync($"/1/channels/current");
        }

        // TODO: http://ip-address:1925/1/channels/current
        public async void SetCurrentChannel()
        {
            await client.PostAsync($"/1/channels/current", new StringContent(""));
        }

        // TODO: http://ip-address:1925/1/channels/id
        public async void GetChannel(string id)
        {
            await client.GetAsync("/1/channels/{id}");
        }
    }
}
