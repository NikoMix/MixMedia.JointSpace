using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MixMedia.JointSpace.Models.Responses
{
    public class NameResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
