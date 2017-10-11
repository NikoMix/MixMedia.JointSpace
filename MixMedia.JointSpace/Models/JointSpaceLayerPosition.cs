using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

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
