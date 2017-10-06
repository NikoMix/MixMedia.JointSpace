using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class ModelResponse
    {
        [JsonProperty("model")]
        public string Model { get; set; }
    }
}
