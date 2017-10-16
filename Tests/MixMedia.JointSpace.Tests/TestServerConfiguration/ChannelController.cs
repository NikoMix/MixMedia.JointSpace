using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace MixMedia.JointSpace.Tests.TestServerConfiguration
{
    [Route("1/channels")]
    public class ChannelController : Controller
    {
        [HttpGet]
        public string GetAll()
        {
            return ResponseMessages.ChannelsGetAll;
        }

        [HttpGet("current")]
        public string GetCurrent()
        {
            return ResponseMessages.ChannelsGetCurrent;
        }

        [HttpPost]
        public void SetCurrent(string id)
        {
            
        }

        [HttpGet("{id}")]
        public string GetChannel(string id)
        {
            return ResponseMessages.ChannelsGetChannel;
        }
    }
}
