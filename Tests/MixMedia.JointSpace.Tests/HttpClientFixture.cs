using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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
        }
    }
}
