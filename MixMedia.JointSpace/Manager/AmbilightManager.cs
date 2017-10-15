using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Ambilight;
using MixMedia.JointSpace.Models.Requests;

namespace MixMedia.JointSpace.Manager
{
    public class AmbilightManager
    {
        private readonly HttpClient _client;

        public AmbilightManager(HttpClient client)
        {
            _client = client;
        }
        
        public async Task<Topology> GetTopology()
        {
            return await _client.GetAsync<Topology>($"/1/ambilight/topology");
        }
        
        public async Task<JointSpaceAmbilightModes> GetMode()
        {
            var response = await _client.GetAsync<AmbilightModeRequest>($"/1/ambilight/mode");
            return response.Mode;
        }
        
        public async Task SetMode(JointSpaceAmbilightModes mode)
        {
            await _client.PostAsync($"/1/ambilight/mode", mode);
        }
        
        public async Task<State> GetAmbilightMeasured()
        {
            return await _client.GetAsync<State>($"/1/ambilight/measured");
        }
        
        public async Task<State> GetAmbilightProcessed()
        {
            return await _client.GetAsync<State>($"/1/ambilight/processed");
        }
    }
}
