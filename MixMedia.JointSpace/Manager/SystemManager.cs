using System;
using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;

namespace MixMedia.JointSpace.Manager
{
    public class SystemManager
    {
        private readonly HttpClient _client;

        public SystemManager(HttpClient client)
        {
            _client = client;
        }

        // TODO: http://ip-address:1925/1/system
        public async void GetSystemDetails()
        {
            await _client.GetAsync($"/1/system");
        }

        // TODO: http://ip-address:1925/1/system/country
        public async Task<JointSpaceCountries> GetCountry()
        {
            await _client.GetAsync($"/1/system/country");
            return JointSpaceCountries.Unknown;
        }

        // TODO: http://ip-address:1925/1/system/name
        public async Task<string> GetName()
        {
            await _client.GetAsync($"/1/system/name");
            return string.Empty;
        }

        // TODO: http://ip-address:1925/1/system/menulanguage
        public async Task<JointSpaceMenuLanguages> GetMenuLanguage()
        {
            await _client.GetAsync($"/1/system/menulanguage");
            return JointSpaceMenuLanguages.Unknown;
        }

        // TODO: http://ip-address:1925/1/system/serialnumber
        public async Task<string> GetSerialNumber()
        {
            await _client.GetAsync($"/1/system/serialnumber");
            return String.Empty;
        }

        // TODO: http://ip-address:1925/1/system/model
        public async Task<string> GetModel()
        {
            await _client.GetAsync($"/1/system/model");
            return String.Empty;
        }

        // TODO: http://ip-address:1925/1/system/softwareversion
        public async Task<string> GetSoftwareVersion()
        {
            await _client.GetAsync($"/1/system/softwareversion");
            return String.Empty;
        }
    }
}
