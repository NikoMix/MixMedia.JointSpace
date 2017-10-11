using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.JointSpace.Controller;
using MixMedia.JointSpace.Manager;
using Xunit;
using Xunit.Abstractions;

namespace MixMedia.JointSpace.Tests
{
    public class ChannelManagerTests
    {
        private readonly ITestOutputHelper output;
        private readonly HttpClient client;
        private readonly ChannelManager manager;

        public ChannelManagerTests(ITestOutputHelper output)
        {
            this.output = output;
            client = new HttpClient() { BaseAddress = new Uri("http://192.168.0.13:1925") };
            manager = new ChannelManager(client);
        }

        [Fact]
        public async Task SystemManagerTest()
        {
            var result = await manager.GetChannels();
            
            Assert.NotEmpty(result);
        }

    }
}
