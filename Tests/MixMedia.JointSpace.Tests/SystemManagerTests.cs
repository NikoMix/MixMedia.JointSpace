using System.Threading.Tasks;
using MixMedia.JointSpace.Manager;
using MixMedia.JointSpace.Models;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class SystemManagerTests : IClassFixture<HttpClientFixture>
    {
        private readonly SystemManager _manager;

        public SystemManagerTests(HttpClientFixture clientFixture)
        {
            _manager = new SystemManager(clientFixture.Client);
        }

        [Fact]
        public async Task SystemManagerGetSoftwareVersionTest()
        {
            var result = await _manager.GetSoftwareVersion();
            
            Assert.NotEqual(result, string.Empty);
        }

        [Fact]
        public async Task SystemManagerGetModelTest()
        {
            var result = await _manager.GetModel();
            
            Assert.NotEqual(result, string.Empty);
        }

        [Fact]
        public async Task SystemManagerGetNameTest()
        {
            var result = await _manager.GetName();
            
            Assert.NotEqual(result, string.Empty);
        }

        [Fact]
        public async Task SystemManagerGetMenuLanguageTest()
        {
            var result = await _manager.GetMenuLanguage();
            
            Assert.IsType<JointSpaceMenuLanguages>(result);
        }

        [Fact]
        public async Task SystemManagerGetCountryTest()
        {
            var result = await _manager.GetCountry();
            
            Assert.IsType<JointSpaceCountries>(result);
        }

        [Fact]
        public async Task SystemManagerGetSerialNumberTest()
        {
            var result = await _manager.GetSerialNumber();
            
            Assert.IsType<string>(result);
        }

        [Fact]
        public async Task SystemManagerGetSystemDetailsTest()
        {
            var result = await _manager.GetSystemDetails();
            
            Assert.IsType<Models.System>(result);
        }
    }
}
