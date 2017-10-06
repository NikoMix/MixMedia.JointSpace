using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class AmbilightModeResponse
    {
        [JsonProperty("current")]
        public JointSpaceAmbilightModes Current { get; set; }
    }
}
