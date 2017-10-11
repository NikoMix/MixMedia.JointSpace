using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MixMedia.JointSpace.Models.Ambilight
{
    public class Topology
    {
        [JsonProperty("layers")]
        public int Layers { get; set; }

        [JsonProperty("left")]
        public int LeftPanel { get; set; }

        [JsonProperty("top")]
        public int TopPanel { get; set; }

        [JsonProperty("right")]
        public int RightPanel { get; set; }

        [JsonProperty("bottom")]
        public int BottomPanel { get; set; }
    }
}
