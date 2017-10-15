using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MixMedia.JointSpace.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JointSpaceLayerPosition
    {
        [EnumMember(Value = "left")]
        Left,

        [EnumMember(Value = "right")]
        Right,

        [EnumMember(Value = "top")]
        Top,

        [EnumMember(Value = "bottom")]
        Bottom
    }
}
