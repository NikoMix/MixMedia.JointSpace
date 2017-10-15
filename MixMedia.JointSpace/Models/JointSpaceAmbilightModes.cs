using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MixMedia.JointSpace.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JointSpaceAmbilightModes
    {
        /// <summary>
        /// The internal ambilight algorithm is used to calculate the ambilight colours
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal,

        /// <summary>
        /// The cached ambilight colours are shown.
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual,

        /// <summary>
        /// The cached ambilight colours are used as input for the internal ambilight algorithm.
        /// </summary>
        [EnumMember(Value = "expert")]
        Expert
    }
}
