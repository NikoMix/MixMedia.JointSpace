using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Requests;
using MixMedia.JointSpace.Models.Responses;

namespace MixMedia.JointSpace.Manager
{
    public class AudioManager
    {
        private readonly HttpClient _client;
        
        public AudioManager(HttpClient client)
        {
            _client = client;
        }
        
        public async Task<Volume> GetAudioVolume()
        {
            return await _client.GetAsync<Volume>($"/1/audio/volume");
        }

        public async void SetAudioVolume(int volume)
        {
            await _client.PostAsync($"/1/audio/volume", new SetVolumeRequest{ Volume = volume});
        }

        public async void SetAudioMute(bool muted)
        {
            await _client.PostAsync($"/1/audio/volume", new SetVolumeRequest { Muted = muted });
        }
    }
}
