using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Requests
{
    public class AmbilightModeRequest
    {
        [JsonProperty("current")]
        public JointSpaceAmbilightModes Mode { get; set; }
    }
}
