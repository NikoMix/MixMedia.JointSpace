using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Requests
{
    public class SwitchChannelRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
