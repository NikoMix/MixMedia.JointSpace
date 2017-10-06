using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models.Requests;

namespace MixMedia.JointSpace.Manager
{
    public class AudioManager
    {
        private readonly HttpClient client;

        public AudioManager(HttpClient client)
        {
            this.client = client;
        }

        // TODO: http://ip-address:1925/1/audio/volume
        public async void GetAudioVolume()
        {
            await client.GetAsync($"/1/audio/volume");
        }

        // TODO: http://ip-address:1925/1/audio/volume
        public async void SetAudioVolume(bool muted, int volume)
        {
            var setVolume = new SetVolumeRequest();
            await client.PostAsync($"/1/audio/volume", new StringContent(""));
        }
    }
}
