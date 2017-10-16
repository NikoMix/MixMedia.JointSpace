using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models.Channel;

namespace MixMedia.JointSpace.Manager
{
    public class ChannellistManager
    {
        private readonly HttpClient _client;

        public ChannellistManager(HttpClient client)
        {
            _client = client;
        }

        public async Task<ChannelList<ChannelListDetails>> GetChannelLists()
        {
            return await _client.GetAsync<ChannelList<ChannelListDetails>>($"/1/channellists");
        }

        public async Task<List<string>> GetChannelList(string id)
        {
            return await _client.GetAsync<List<string>>($"/1/channellists/{id}");
        }
    }
}
