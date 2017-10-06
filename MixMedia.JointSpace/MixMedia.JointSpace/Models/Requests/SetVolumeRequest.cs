using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Requests
{
    public class SetVolumeRequest
    {
        /// <summary>
        /// Set to true to mute the sound or false to unmute the sound.
        /// </summary>
        [JsonProperty("muted")]
        public bool Muted { get; set; }

        /// <summary>
        /// The new volume setting. This should be between the min and max as returned by GET audio/volume.
        /// </summary>
        [JsonProperty("current")]
        public int Volume { get; set; }
    }
}
