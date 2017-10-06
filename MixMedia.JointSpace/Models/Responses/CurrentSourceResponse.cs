using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class CurrentSourceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
