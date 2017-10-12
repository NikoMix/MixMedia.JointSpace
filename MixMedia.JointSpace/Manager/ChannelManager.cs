using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Channel;

namespace MixMedia.JointSpace.Manager
{
    /// <summary>
    /// Since TV is not connected to cable network, cannot Test Channel Methods
    /// </summary>
    public class ChannelManager
    {
        private readonly HttpClient _client;

        public ChannelManager(HttpClient client)
        {
            _client = client;
        }

        public async Task<ChannelList> GetChannels()
        {
            return await _client.GetAsync<ChannelList>($"/1/channels");
        }
        
        public async Task<string> GetCurrentChannel()
        {
            var result = await _client.GetAsync<CurrentObject>($"/1/channels/current");
            return result.Id;
        }
        
        public async void SetCurrentChannel(string id)
        {
            await _client.PostAsync($"/1/channels/current", new CurrentObject{Id = id});
        }
        
        public async Task<ChannelExtendedDetails> GetChannel(string id)
        {
            return await _client.GetAsync<ChannelExtendedDetails>("/1/channels/{id}");
        }
    }
}
