using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.JointSpace.Models
{
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
