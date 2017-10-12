using System;
using System.Net.Http;

namespace MixMedia.JointSpace.Tests
{
    public class HttpClientFixture : IDisposable
    {
        public HttpClient Client { get; set; }

        public HttpClientFixture()
        {
            Client = new HttpClient { BaseAddress = new Uri("http://192.168.0.13:1925") };
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
