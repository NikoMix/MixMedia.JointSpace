using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Channel
{
    public class ChannelListDetails
    {
        /// <summary>
        /// The name of the channel list.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Either "tv" for TV channels or "satellite" for satellite channels.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
