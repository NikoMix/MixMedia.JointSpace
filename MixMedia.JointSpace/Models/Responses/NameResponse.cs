using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class NameResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
