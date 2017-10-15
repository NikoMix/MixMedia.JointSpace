using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace MixMedia.JointSpace.Tests.TestServerConfiguration
{
    [Route("1/input")]
    public class InputController : Controller
    {
        [HttpPost("key")]
        public void SendKey(string key)
        {
            // Empty since no processing / answer expected
        }
    }
}
