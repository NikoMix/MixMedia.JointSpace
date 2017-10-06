using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Requests
{
    public class SendKeyRequest
    {
        [JsonProperty("key")]
        public JointSpaceKeys Key { get; set; }
    }
}
