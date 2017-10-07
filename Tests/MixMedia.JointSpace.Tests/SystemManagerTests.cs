using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.JointSpace.Manager;
using Xunit;
using Xunit.Abstractions;

namespace MixMedia.JointSpace.Tests
{
    public class SystemManagerTests
    {
        private readonly ITestOutputHelper output;
        private readonly HttpClient client;
        private readonly SystemManager manager;

        public SystemManagerTests(ITestOutputHelper output)
        {
            this.output = output;
            client = new HttpClient() { BaseAddress = new Uri("http://<localip>:1925") };
            manager = new SystemManager(client);
        }

        [Fact]
        public async Task SystemManagerGetSoftwareVersionTest()
        {
            var result = await manager.GetSoftwareVersion();

            output.WriteLine(result);
            Assert.NotEqual(result, string.Empty);
        }

        [Fact]
        public async Task SystemManagerGetModelTest()
        {
            var result = await manager.GetModel();

            output.WriteLine(result);
            Assert.NotEqual(result, string.Empty);
        }

        [Fact]
        public async Task SystemManagerGetNameTest()
        {
            var result = await manager.GetName();

            output.WriteLine(result);
            Assert.NotEqual(result, string.Empty);
        }

        [Fact]
        public async Task SystemManagerGetMenuLanguageTest()
        {
            var result = await manager.GetMenuLanguage();

            output.WriteLine(result.ToString());
            Assert.True(true);
        }

        [Fact]
        public async Task SystemManagerTest()
        {
            var result = await manager.GetCountry();

            output.WriteLine(result.ToString());
            Assert.True(true);
        }

        [Fact]
        public async Task SystemManagerGetSystemDetailsTest()
        {
            var result = await manager.GetSystemDetails();

            output.WriteLine(result.Name);
            output.WriteLine(result.Country);
            output.WriteLine(result.MenuLanguage);
            output.WriteLine(result.SerialNumber);
            output.WriteLine(result.SoftwareVersion);
            Assert.True(true);
        }
    }
}
