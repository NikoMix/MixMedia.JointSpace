using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using MixMedia.JointSpace.Tests.TestServerConfiguration;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public class HttpClientFixture : IDisposable
    {
        private readonly TestServer _server;
        public HttpClient Client { get; set; }

        public HttpClientFixture()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            //Client = _server.CreateClient();

            // To Test against a real Device uncomment this line and replace <IP Address>
             Client = new HttpClient { BaseAddress = new Uri("http://192.168.0.13:1925") };
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
