using System.Threading.Tasks;
using MixMedia.JointSpace.Manager;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class ChannelManagerTests : IClassFixture<HttpClientFixture>
    {
        private readonly ChannelManager _manager;

        public ChannelManagerTests(HttpClientFixture clientFixture)
        {
            _manager = new ChannelManager(clientFixture.Client);
        }

        [Fact]
        public async Task ChannelManagerGetChannelsTest()
        {
            var result = await _manager.GetChannels();
            
            Assert.NotEmpty(result);
        }

    }
}
