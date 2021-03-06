﻿using System.Threading.Tasks;
using MixMedia.JointSpace.Manager;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class AudioManagerTests : IClassFixture<HttpClientFixture>
    {
        private readonly AudioManager _manager;
        public AudioManagerTests(HttpClientFixture clientFixture)
        {
            _manager = new AudioManager(clientFixture.Client);
        }

        [Fact]
        public async Task AudioManagerGetVolumeTest()
        {
            var result = await _manager.GetAudioVolume();
            Assert.NotNull(result);
        }

        [Fact]
        public void AudioManagerSetVolumeTest()
        {
            _manager.SetAudioVolume(60);
            // If no Exception - pass Test
            Assert.True(true);
        }

        [Fact]
        public void AudioManagerSetVolumeMute()
        {
            _manager.SetAudioMute(true);
            // If no Exception - pass Test
            Assert.True(true);
        }
    }
}
