using System.Net;
using System.Threading.Tasks;
using MixMedia.JointSpace.Controller;
using MixMedia.JointSpace.Models;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class InputManagerTests : IClassFixture<HttpClientFixture>
    {
        private readonly InputManager _manager;

        public InputManagerTests(HttpClientFixture clientFixture)
        {
            _manager = new InputManager(clientFixture.Client);
        }

        [Theory]
        [InlineData(JointSpaceKeys.Standby)]
        [InlineData(JointSpaceKeys.Adjust)]
        [InlineData(JointSpaceKeys.AmbilightOnOff)]
        [InlineData(JointSpaceKeys.Back)]
        [InlineData(JointSpaceKeys.BlueColour)]
        [InlineData(JointSpaceKeys.ChannelStepDown)]
        [InlineData(JointSpaceKeys.ChannelStepUp)]
        [InlineData(JointSpaceKeys.Confirm)]
        [InlineData(JointSpaceKeys.CursorDown)]
        [InlineData(JointSpaceKeys.CursorLeft)]
        [InlineData(JointSpaceKeys.CursorRight)]
        [InlineData(JointSpaceKeys.CursorUp)]
        [InlineData(JointSpaceKeys.Digit0)]
        [InlineData(JointSpaceKeys.Digit1)]
        [InlineData(JointSpaceKeys.Digit2)]
        [InlineData(JointSpaceKeys.Digit3)]
        [InlineData(JointSpaceKeys.Digit4)]
        [InlineData(JointSpaceKeys.Digit5)]
        [InlineData(JointSpaceKeys.Digit6)]
        [InlineData(JointSpaceKeys.Digit7)]
        [InlineData(JointSpaceKeys.Digit8)]
        [InlineData(JointSpaceKeys.Digit9)]
        [InlineData(JointSpaceKeys.Dot)]
        [InlineData(JointSpaceKeys.Stop)]
        public async Task InputManagerSendKeyTestAsync(JointSpaceKeys key)
        {
            var result = await _manager.SendKey(key);

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }
    }
}
