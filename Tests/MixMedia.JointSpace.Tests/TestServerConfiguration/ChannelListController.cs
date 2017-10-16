using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace MixMedia.JointSpace.Tests.TestServerConfiguration
{
    [Route("1/channellists")]
    public class ChannelListController : Controller
    {
        [HttpGet]
        public string GetAllChannels()
        {
            return ResponseMessages.ChannelListGetAll;
        }

        [HttpGet("{id}")]
        public string GetChannel(string id)
        {
            return ResponseMessages.ChannelListGetChannelList;
        }
    }
}
