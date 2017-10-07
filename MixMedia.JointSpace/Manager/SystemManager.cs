using System;
using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Responses;

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
        public async Task<SystemResponse> GetSystemDetails()
        {
            return await _client.GetAsync<SystemResponse>($"/1/system");
        }

        // TODO: http://ip-address:1925/1/system/country
        public async Task<JointSpaceCountries> GetCountry()
        {
            var response = await _client.GetAsync<CountryResponse>($"/1/system/country");
            return response.Country;
        }

        // TODO: http://ip-address:1925/1/system/name
        public async Task<string> GetName()
        {
            var response = await _client.GetAsync<NameResponse>($"/1/system/name");
            return response.Name;
        }

        // TODO: http://ip-address:1925/1/system/menulanguage
        public async Task<JointSpaceMenuLanguages> GetMenuLanguage()
        {
            var response = await _client.GetAsync<MenuLanguageResponse>($"/1/system/menulanguage");
            return response.MenuLanguage;
        }

        // TODO: http://ip-address:1925/1/system/serialnumber
        public async Task<string> GetSerialNumber()
        {
            var response = await _client.GetAsync<SerialNumberResponse>($"/1/system/serialnumber");
            return response.SerialNumber;
        }

        // TODO: http://ip-address:1925/1/system/model
        public async Task<string> GetModel()
        {
            var response = await _client.GetAsync<ModelResponse>($"/1/system/model");
            return response.Model;
        }

        // TODO: http://ip-address:1925/1/system/softwareversion
        public async Task<string> GetSoftwareVersion()
        {
            var response = await _client.GetAsync<SoftwareVersionResponse>($"/1/system/softwareversion");
            return response.SoftwareVersion;
        }
    }
}
