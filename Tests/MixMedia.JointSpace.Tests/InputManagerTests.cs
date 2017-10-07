using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.JointSpace.Controller;
using MixMedia.JointSpace.Manager;
using MixMedia.JointSpace.Models;
using MixMedia.JointSpace.Models.Requests;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace MixMedia.JointSpace.Tests
{
    public class InputManagerTests
    {
        private readonly ITestOutputHelper output;
        private readonly HttpClient client;
        private readonly InputManager manager;

        public InputManagerTests(ITestOutputHelper output)
        {
            this.output = output;
            client = new HttpClient() { BaseAddress = new Uri("http://<localip>:1925") };
            manager = new InputManager(client);
        }

        [Fact]
        public void SendKeyMessageSerializationTestAsync()
        {
            var request = new SendKeyRequest() {Key = JointSpaceKeys.Standby};
            var message = JsonConvert.SerializeObject(request);
            Assert.NotNull(message);
            Assert.NotEqual(message, new SendKeyRequest().ToString());
        }


        [Fact]
        public async Task InputManagerSendKeyTestAsync()
        {
            var result = await manager.SendKey(JointSpaceKeys.Standby);

            Assert.Equal(result.StatusCode, HttpStatusCode.OK);
        }
    }
}
