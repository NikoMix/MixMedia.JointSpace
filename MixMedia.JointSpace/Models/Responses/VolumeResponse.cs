using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class VolumeResponse
    {
        /// <summary>
        /// Set to true if the sound is muted, false if not.
        /// </summary>
        [JsonProperty("muted")]
        public bool Muted { get; set; }

        /// <summary>
        /// The actual volume.
        /// </summary>
        [JsonProperty("current")]
        public int Current { get; set; }

        /// <summary>
        /// The minimum volume.
        /// </summary>
        [JsonProperty("min")]
        public int Minimum { get; set; }

        /// <summary>
        /// The maximum volume.
        /// </summary>
        [JsonProperty("max")]
        public int Maximum { get; set; }
    }
}
