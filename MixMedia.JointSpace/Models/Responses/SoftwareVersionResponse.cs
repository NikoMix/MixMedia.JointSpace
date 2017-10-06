using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class SoftwareVersionResponse
    {
        [JsonProperty("softwareversion")]
        public string SoftwareVersion { get; set; }
    }
}
