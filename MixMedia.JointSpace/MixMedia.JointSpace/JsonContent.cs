using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MixMedia.JointSpace
{
    public class JsonContent<T> : StringContent
    {
        public JsonContent(T content) 
            : base(GetJsonString(content), Encoding.UTF8, "application/json")
        {
        }

        public JsonContent(T content, Encoding encoding) 
            : base(GetJsonString(content), encoding, "application/json")
        {
        }

        public JsonContent(T content, Encoding encoding, string mediaType) 
            : base(GetJsonString(content), encoding, mediaType)
        {
        }

        private static string GetJsonString(T content)
        {
            return JsonConvert.SerializeObject(content);
        }
    }
}
