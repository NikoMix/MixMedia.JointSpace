using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MixMedia.JointSpace.Models;

namespace MixMedia.JointSpace.Tests.TestServerConfiguration
{
    [Route("1/sources")]
    public class SourcesController : Controller
    {
        [HttpGet]
        public string GetSources()
        {
            return ResponseMessages.SourcesGetSources;
        }

        [HttpGet("current")]
        public string GetCurrentSource()
        {
            return ResponseMessages.SourcesGetCurrent;
        }


    }
}
