using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype;
using System.Threading;

namespace CreationalPatternsTest
{
    [TestClass]
    public class PrototypeTest
    {
        ColorManager colormanager = new ColorManager();

        [TestMethod]
        public void PrototypeColorInstanceCheck()
        {
            colormanager["red"] = new Color(255, 0, 0);
            Color red = colormanager["red"].Clone() as Color;
            Assert.IsNotNull(red);
            Assert.IsInstanceOfType(red, typeof(Color));
        }

        [TestMethod]
        public void PrototypeColorInstanceGreenCheck()
        {
            colormanager["green"] = new Color(0, 255, 0);
            Color green = colormanager["green"].Clone() as Color;
            Assert.IsNotNull(green);
            Assert.IsInstanceOfType(green, typeof(Color));
        }

        [TestMethod]
        public void PrototypeColorInstanceBlueCheck()
        {
            colormanager["blue"] = new Color(0, 0, 255);
            Color blue = colormanager["blue"].Clone() as Color;
            Assert.IsNotNull(blue);
            Assert.IsInstanceOfType(blue, typeof(Color));
        }
    }
}
