using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models
{
    public class ChannelDetails
    {
        [JsonProperty("preset")]
        public string Preset { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
