using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Ambilight;

namespace MixMedia.JointSpace.Manager
{
    public class AmbilightManager
    {
        private readonly HttpClient client;

        public AmbilightManager(HttpClient client)
        {
            this.client = client;
        }
        
        public async Task<Topology> GetTopology()
        {
            return await client.GetAsync<Topology>($"/1/ambilight/topology");
        }

        // TODO: http://ip-address:1925/1/ambilight/mode
        public async void GetMode()
        {
            await client.GetAsync($"/1/ambilight/mode");
        }

        // TODO: http://ip-address:1925/1/ambilight/mode
        public async void SetMode(JointSpaceAmbilightModes mode)
        {
            await client.PostAsync($"/1/ambilight/mode", new StringContent(""));
        }
        
        public async Task<State> GetAmbilightMeasured()
        {
            return await client.GetAsync<State>($"/1/ambilight/measured");
        }

        // TODO: http://ip-address:1925/1/ambilight/processed
        public async Task<State> GetAmbilightProcessed()
        {
            return await client.GetAsync<State>($"/1/ambilight/processed");
        }
    }
}
