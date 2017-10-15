using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace MixMedia.JointSpace.Tests.TestServerConfiguration
{
    [Route("1/audio")]
    public class AudioController : Controller
    {
        [HttpGet("volume")]
        public string GetVolume()
        {
            return ResponseMessages.AudioGetVolumne;
        }

        [HttpPost("volume")]
        public void SetVolume()
        {
            // Empty since no processing / answer expected
        }
    }
}
