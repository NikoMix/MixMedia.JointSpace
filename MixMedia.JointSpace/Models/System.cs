using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models
{
    public class System
    {
        /// <summary>
        /// The current menu language.
        /// </summary>
        [JsonProperty("menulanguage")]
        public string MenuLanguage { get; set; }

        /// <summary>
        /// The name of the TV.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The installation country.One of the following:
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The serial number.
        /// </summary>
        [JsonProperty("serialnumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The software version.
        /// </summary>
        [JsonProperty("softwareversion")]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// The model.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }
    }
}
