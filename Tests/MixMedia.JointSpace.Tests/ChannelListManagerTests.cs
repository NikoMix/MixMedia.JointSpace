using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MixMedia.JointSpace.Manager;
using MixMedia.JointSpace.Models.Channel;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class ChannelListManagerTests : IClassFixture<HttpClientFixture>
    {
        private readonly ChannellistManager _manager;

        public ChannelListManagerTests(HttpClientFixture clientFixture)
        {
            _manager = new ChannellistManager(clientFixture.Client);
        }

        [Fact]
        public async Task ChannelListManagerGetChannelLists()
        {
            var result = await _manager.GetChannelLists();
            
        }

        [Fact]
        public async Task ChannelListManagerGetChannelList()
        {
            var result = await _manager.GetChannelList("fingerprint-1");
            Assert.NotEmpty(result);
        }
    }
}
