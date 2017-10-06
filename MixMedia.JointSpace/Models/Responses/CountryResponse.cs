using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class CountryResponse
    {
        [JsonProperty("country")]
        public JointSpaceCountries Country { get; set; }
    }
}
