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
        /// <summary>
        /// The preset number of the channel.
        /// </summary>
        [JsonProperty("preset")]
        public string Preset { get; set; }

        /// <summary>
        /// The name of the channel.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
