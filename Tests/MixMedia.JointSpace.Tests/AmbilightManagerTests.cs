using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MixMedia.JointSpace.Manager;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class AmbilightManagerTests : IClassFixture<HttpClientFixture>
    {
        private readonly AmbilightManager _manager;

        public AmbilightManagerTests(HttpClientFixture clientFixture)
        {
            _manager = new AmbilightManager(clientFixture.Client);
        }

        [Fact]
        public async Task SourceManagerGetSourcesTest()
        {
            var result = await _manager.GetAmbilightMeasured();
            Assert.NotEmpty(result);
         
        }
    }
}
