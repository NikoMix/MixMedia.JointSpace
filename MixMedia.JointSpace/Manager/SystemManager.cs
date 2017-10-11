using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
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
        
        public async Task<Models.System> GetSystemDetails()
        {
            return await _client.GetAsync<Models.System>($"/1/system");
        }
        
        public async Task<JointSpaceCountries> GetCountry()
        {
            var response = await _client.GetAsync<CountryResponse>($"/1/system/country");
            return response.Country;
        }
        
        public async Task<string> GetName()
        {
            var response = await _client.GetAsync<NameResponse>($"/1/system/name");
            return response.Name;
        }
        
        public async Task<JointSpaceMenuLanguages> GetMenuLanguage()
        {
            var response = await _client.GetAsync<MenuLanguageResponse>($"/1/system/menulanguage");
            return response.MenuLanguage;
        }
        
        public async Task<string> GetSerialNumber()
        {
            var response = await _client.GetAsync<SerialNumberResponse>($"/1/system/serialnumber");
            return response.SerialNumber;
        }

        public async Task<string> GetModel()
        {
            var response = await _client.GetAsync<ModelResponse>($"/1/system/model");
            return response.Model;
        }
        
        public async Task<string> GetSoftwareVersion()
        {
            var response = await _client.GetAsync<SoftwareVersionResponse>($"/1/system/softwareversion");
            return response.SoftwareVersion;
        }
    }
}
