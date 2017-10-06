using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;

namespace MixMedia.JointSpace.Manager
{
    public class AmbilightManager
    {
        private readonly HttpClient client;

        public AmbilightManager(HttpClient client)
        {
            this.client = client;
        }

        // TODO: http://ip-address:1925/1/ambilight/topology
        public async void GetTopology()
        {
            await client.GetAsync($"/1/ambilight/topology");
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

        // TODO: http://ip-address:1925/1/ambilight/measured
        public async void GetAmbilightMeasured()
        {
            await client.GetAsync($"/1/ambilight/measured");
        }

        // TODO: http://ip-address:1925/1/ambilight/processed
        public async void GetAmbilightProcessed()
        {
            await client.GetAsync($"/1/ambilight/processed");
        }
    }
}
