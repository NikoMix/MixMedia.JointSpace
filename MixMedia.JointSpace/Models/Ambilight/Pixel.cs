using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Ambilight
{
    public class Pixel
    {
        [JsonProperty("r")]
        public int R { get; set; }

        [JsonProperty("g")]
        public int G { get; set; }

        [JsonProperty("b")]
        public int B { get; set; }
    }
}
