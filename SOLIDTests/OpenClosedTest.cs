using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenClosed;
using System.Collections.Generic;

namespace SOLIDTests
{
    [TestClass]
    public class OpenClosedTest
    {
        List<ShapeBad> shapes = new List<ShapeBad>();
        AreaCalculatorBad areaCalculatorBad = new AreaCalculatorBad();

        List<Shape> shapes2 = new List<Shape>();
        AreaCalculator areaCalculator = new AreaCalculator();

        [TestInitialize]
        public void Init()
        {
            shapes.Add(new RectangleBad(10, 20));
            shapes.Add(new SquareBad(10));

            shapes2.Add(new Rectangle(10, 20));
            shapes2.Add(new Square(10));
        }

        [TestMethod]
        public void GetSquareAreaBad()
        {
            var area = areaCalculatorBad.AreaBad(shapes);
            Assert.AreEqual(area, 300);
       } 

        [TestMethod]
        public void GetSquareArea()
        {
            var area = areaCalculator.Area(shapes2);
            Assert.AreEqual(area, 300);
        }
    }
}
