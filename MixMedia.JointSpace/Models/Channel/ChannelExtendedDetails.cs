using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Channel
{
    public class ChannelExtendedDetails : ChannelDetails
    {
        /// <summary>
        /// The frequency of the channel.
        /// </summary>
        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// The Original Network ID of a digital channel or N/A.
        /// </summary>
        [JsonProperty("onid")]
        public string OnId { get; set; }

        /// <summary>
        /// The Transport Stream ID of a digital channel or N/A.
        /// </summary>
        [JsonProperty("tsid")]
        public string Tsid { get; set; }

        /// <summary>
        /// The Service ID of a digital channel or N/A.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// Set to true if the channel is analog, false if not.
        /// </summary>
        [JsonProperty("analog")]
        public bool Analog { get; set; }

        /// <summary>
        /// DVB for digital terrestrial or cable channels, DVB-S2 for satellite channels or N/A.
        /// </summary>
        [JsonProperty("digital")]
        public string Digital { get; set; }
    }
}
