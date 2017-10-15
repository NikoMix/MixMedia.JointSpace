using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace MixMedia.JointSpace.Tests.TestServerConfiguration
{
    [Route("1/system")]
    public class SystemController : Controller
    {
        [HttpGet]
        public string GetSystemInformation()
        {
            return ResponseMessages.SystemGetDetails;
        }

        [HttpGet("country")]
        public string GetCountry()
        {
            return ResponseMessages.SystemGetCountry;
        }

        [HttpGet("name")]
        public string GetName()
        {
            return ResponseMessages.SystemGetName;
        }

        [HttpGet("menulanguage")]
        public string GetMenuLanguage()
        {
            return ResponseMessages.SystemGetMenuLanguage;
        }

        [HttpGet("serialnumber")]
        public string GetSerialNumber()
        {
            return ResponseMessages.SystemGetVersionNumber;
        }

        [HttpGet("model")]
        public string GetModel()
        {
            return ResponseMessages.SystemGetModel;
        }

        [HttpGet("softwareversion")]
        public string GetSoftwareVersion()
        {
            return ResponseMessages.SystemGetVersionNumber;
        }
    }
}
