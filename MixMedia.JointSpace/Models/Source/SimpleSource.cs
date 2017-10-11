using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Source
{

    public class SimpleSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
