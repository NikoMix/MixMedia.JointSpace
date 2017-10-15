using System.Threading.Tasks;
using MixMedia.JointSpace.Manager;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Ambilight;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class AmbilightManagerTests : IClassFixture<HttpClientFixture>
    {
        private readonly AmbilightManager _manager;

        public AmbilightManagerTests(HttpClientFixture clientFixture)
        {
            _manager = new AmbilightManager(clientFixture.Client);
        }

        [Fact]
        public async Task GetTopologyTest()
        {
            var result = await _manager.GetTopology();
            
            Assert.Equal(1, result.Layers);
            Assert.Equal(4, result.LeftPanel);
            Assert.Equal(4, result.RightPanel);
            Assert.Equal(9, result.TopPanel);
            Assert.Equal(0, result.BottomPanel);
        }

        [Fact]
        public async Task GetModeTest()
        {
            var result = await _manager.GetMode();

            Assert.IsType<JointSpaceAmbilightModes>(result);
            Assert.Equal(JointSpaceAmbilightModes.Internal, result);
        }

        [Fact]
        public async Task SetModeTest()
        {
            await _manager.SetMode(JointSpaceAmbilightModes.Manual);
        }

        [Fact]
        public async Task GetCachedAmbilightTest()
        {
            var result = await _manager.GetAmbilightMeasured();
            Assert.IsType<State>(result);
        }

        [Fact]
        public async Task GetProcessedAmbilightTest()
        {
            var result = await _manager.GetAmbilightProcessed();
            Assert.IsType<State>(result);

            var leftPanel = result["layer1"][JointSpaceLayerPosition.Left];
            Assert.Equal(104, leftPanel[0].R);
            Assert.Equal(91, leftPanel[0].G);
            Assert.Equal(99, leftPanel[0].B);

            Assert.Equal(58, leftPanel[1].R);
            Assert.Equal(89, leftPanel[1].G);
            Assert.Equal(107, leftPanel[1].B);

            Assert.Equal(23, leftPanel[2].R);
            Assert.Equal(98, leftPanel[2].G);
            Assert.Equal(130, leftPanel[2].B);

            Assert.Equal(21, leftPanel[3].R);
            Assert.Equal(59, leftPanel[3].G);
            Assert.Equal(92, leftPanel[3].B);

            var rightPanel = result["layer1"][JointSpaceLayerPosition.Right];
            Assert.Equal(58, rightPanel[0].R);
            Assert.Equal(58, rightPanel[0].G);
            Assert.Equal(88, rightPanel[0].B);

            Assert.Equal(28, rightPanel[1].R);
            Assert.Equal(104, rightPanel[1].G);
            Assert.Equal(147, rightPanel[1].B);

            Assert.Equal(53, rightPanel[2].R);
            Assert.Equal(89, rightPanel[2].G);
            Assert.Equal(111, rightPanel[2].B);

            Assert.Equal(109, rightPanel[3].R);
            Assert.Equal(95, rightPanel[3].G);
            Assert.Equal(101, rightPanel[3].B);

            var topPanel = result["layer1"][JointSpaceLayerPosition.Top];
            Assert.Equal(23, topPanel[0].R);
            Assert.Equal(49, topPanel[0].G);
            Assert.Equal(79, topPanel[0].B);

            Assert.Equal(15, topPanel[1].R);
            Assert.Equal(43, topPanel[1].G);
            Assert.Equal(75, topPanel[1].B);

            Assert.Equal(7, topPanel[2].R);
            Assert.Equal(37, topPanel[2].G);
            Assert.Equal(68, topPanel[2].B);

            Assert.Equal(13, topPanel[3].R);
            Assert.Equal(42, topPanel[3].G);
            Assert.Equal(74, topPanel[3].B);

            Assert.Equal(11, topPanel[4].R);
            Assert.Equal(40, topPanel[4].G);
            Assert.Equal(71, topPanel[4].B);

            Assert.Equal(13, topPanel[5].R);
            Assert.Equal(41, topPanel[5].G);
            Assert.Equal(73, topPanel[5].B);

            Assert.Equal(10, topPanel[6].R);
            Assert.Equal(39, topPanel[6].G);
            Assert.Equal(70, topPanel[6].B);

            Assert.Equal(19, topPanel[7].R);
            Assert.Equal(47, topPanel[7].G);
            Assert.Equal(78, topPanel[7].B);

            Assert.Equal(27, topPanel[8].R);
            Assert.Equal(54, topPanel[8].G);
            Assert.Equal(86, topPanel[8].B);

            var bottomPanel = result["layer1"][JointSpaceLayerPosition.Bottom];
            Assert.Empty(bottomPanel);
        }
    }
}
