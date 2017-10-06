using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Requests
{
    public class SwitchChannelRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
