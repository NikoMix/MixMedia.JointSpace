using System;
using System.Collections.Generic;
using System.Text;
using MixMedia.JointSpace.Models.Ambilight;
using Xunit;

namespace MixMedia.JointSpace.Tests
{
    public static class AssertHelper
    {
        public static void Equal(this Assert asserter, Pixel pixel, int r, int g, int b)
        {
            Assert.Equal(pixel.R, r);
            Assert.Equal(pixel.G, g);
            Assert.Equal(pixel.B, b);
        }
    }
}
