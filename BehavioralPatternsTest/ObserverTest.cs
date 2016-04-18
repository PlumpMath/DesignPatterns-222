using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer;
namespace BehavioralPatternsTest
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void TestObserverPrice()
        {
            IBM ibm = new IBM("IBM", 120.24);

            var i1 = new Investor("I1");
            var i2 = new Investor("I2");
            ibm.Attach(i1);
            ibm.Attach(i2);

            ibm.Price = 113.24;
            Assert.AreEqual(i1.Stock.Price, 113.24);
            Assert.AreEqual(i2.Stock.Price, 113.24);
        }
    }
}
