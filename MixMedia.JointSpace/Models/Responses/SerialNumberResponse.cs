using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class SerialNumberResponse
    {
        [JsonProperty("serialnumber")]
        public string SerialNumber { get; set; }
    }
}
