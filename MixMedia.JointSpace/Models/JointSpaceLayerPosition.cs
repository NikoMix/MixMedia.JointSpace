using System.Runtime.Serialization;

namespace MixMedia.JointSpace.Models
{
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
