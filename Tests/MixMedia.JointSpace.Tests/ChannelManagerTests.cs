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

        [Fact]
        public async Task ChannelManagerGetCurrentChannelTest()
        {
            var result = await _manager.GetCurrentChannel();

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task ChannelManagerSetCurrentChannelTest()
        {
            await _manager.SetCurrentChannel("fingerprint-1");
        }

        [Fact]
        public async Task ChannelManagerGetChannelTest()
        {
            var result = await _manager.GetChannel("fingerprint-1");

            Assert.NotNull(result);
        }
    }
}
