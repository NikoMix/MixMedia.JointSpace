using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Channel
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
