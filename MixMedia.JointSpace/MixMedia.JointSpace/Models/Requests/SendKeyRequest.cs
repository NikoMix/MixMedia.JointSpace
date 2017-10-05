using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.JointSpace.Models.Requests
{
    public class SendKeyRequest
    {
        [JsonProperty("key")]
        public JointSpaceKeys Key { get; set; }
    }
}
