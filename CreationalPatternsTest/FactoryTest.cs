using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory;
using System.Threading;

namespace CreationalPatternsTest
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void TestFactoryManagerInstance()
        {
            var mgr = PositionFactory.Get(0);
            Assert.IsNotNull(mgr);
            Assert.IsInstanceOfType(mgr, typeof(Position));
            Assert.IsInstanceOfType(mgr, typeof(Manager));
        }

        [TestMethod]
        public void TestFactoryDeveloperInstance()
        {
            var developer = PositionFactory.Get(1);
            Assert.IsNotNull(developer);
            Assert.IsInstanceOfType(developer, typeof(Position));
            Assert.IsInstanceOfType(developer, typeof(Developer));
        }

        [TestMethod]
        public void TestFactoryNullInstance()
        {
            var obj = PositionFactory.Get(3);
            Assert.IsNull(obj);
        }
    }
}