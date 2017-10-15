using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MixMedia.JointSpace.Models.Requests;

namespace MixMedia.JointSpace.Tests.TestServerConfiguration
{
    [Route("1/ambilight")]
    public class AmbilightController : Controller
    {
        [HttpGet("topology")]
        public string Topology()
        {
            return ResponseMessages.GetTopologyResponse;
        }

        [HttpGet("mode")]
        public string GetMode()
        {
            return ResponseMessages.GetAmbilightModeResponse;
        }

        [HttpPost("mode")]
        public void SetMode(AmbilightModeRequest request)
        {

        }

        [HttpGet("measured")]
        public string GetMeasured()
        {
            return ResponseMessages.AmbilightResponse;
        }

        [HttpGet("processed")]
        public string GetProcessed()
        {
            return ResponseMessages.AmbilightResponse;
        }
    }
}