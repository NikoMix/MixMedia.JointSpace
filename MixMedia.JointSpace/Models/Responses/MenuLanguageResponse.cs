using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class MenuLanguageResponse
    {
        [JsonProperty("menulanguage")]
        public JointSpaceMenuLanguages MenuLanguage { get; set; }
    }
}
