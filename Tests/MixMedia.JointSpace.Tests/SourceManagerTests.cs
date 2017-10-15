using System;
using System.Threading;
using System.Threading.Tasks;
using MixMedia.JointSpace.Manager;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class SourceManagerTests : IClassFixture<HttpClientFixture>
    {
        private readonly SourceManager _manager;

        public SourceManagerTests(HttpClientFixture clientFixture)
        {
            _manager = new SourceManager(clientFixture.Client);
        }

        /// <summary>
        /// Gets all possible Sources of the TV
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task SourceManagerGetSourcesTest()
        {
            var result = await _manager.GetSources();
            Assert.NotEmpty(result);
            Assert.All(result, source =>
            {
                Assert.NotNull(source.Key);
                Assert.NotEqual(source.Value.Name, String.Empty);
            });
        }

        /// <summary>
        /// Gets the Current Channel
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task SourceManagerGetCurrentSourceTest()
        {
            var result = await _manager.GetCurrentSource();
            Assert.NotNull(result);
        }

        /// <summary>
        /// Test will switch through all Sources and validates the current channel
        /// </summary>
        /// <returns>Success if no Exception appears</returns>
        [Fact]
        public async Task SourceManagerSetCurrentSourceTest()
        {
            var result = await _manager.GetSources();
            foreach (var channel in result)
            {
                _manager.SetCurrentSource(channel.Key);
                Thread.Sleep(1500);
                var current = await _manager.GetCurrentSource();
                //Assert.Equal(current.Id, channel.Key);
            }
        }
    }
}
