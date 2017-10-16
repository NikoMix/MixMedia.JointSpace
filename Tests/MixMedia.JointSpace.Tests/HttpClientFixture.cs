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
        public HttpClient Client { get; }

        public TestServer Server { get; }

        public HttpClientFixture()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();

            // To Test against a real Device uncomment this line and replace <IP Address>
            // Client = new HttpClient { BaseAddress = new Uri("http://<IP Address>:1925") };
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
