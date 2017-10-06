using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models.Requests;
using MixMedia.JointSpace.Models.Responses;

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
        public async Task<VolumeResponse> GetAudioVolume()
        {
            return await client.GetAsync<VolumeResponse>($"/1/audio/volume");
        }

        // TODO: http://ip-address:1925/1/audio/volume
        public async void SetAudioVolume(bool muted, int volume)
        {
            var setVolume = new SetVolumeRequest();
            await client.PostAsync($"/1/audio/volume", new StringContent(""));
        }
    }
}
