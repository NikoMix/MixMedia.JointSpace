using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public async void GetCurrentChannel()
        {
            
        }

        public async void SetCurrentChannel()
        {
            
        }

        public async void GetChannel(int id)
        {
            
        }
    }
}
