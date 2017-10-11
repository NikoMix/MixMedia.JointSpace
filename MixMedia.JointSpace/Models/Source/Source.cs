using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Source
{
    public class Source
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
