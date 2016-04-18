using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactory;
using System.Threading;

namespace CreationalPatternsTest
{
    [TestClass]
    public class AbstractFactoryTest
    {
        ICarFactory fordFactory = new FordFactory();
        ICarFactory hondaFactory = new HondaFactory();

        [TestMethod]
        public void TestAbstractFordFactoryHatchbackInstance()
        {
            IHatchBack hatchBack = fordFactory.GetHatchBack();
            Assert.IsNotNull(hatchBack);
            Assert.IsInstanceOfType(hatchBack, typeof(Figo));
        }
        [TestMethod]
        public void TestAbstractFordFactorySedanInstance()
        {
            ISedan sedan = fordFactory.GetSedan();
            Assert.IsNotNull(sedan);
            Assert.IsInstanceOfType(sedan, typeof(Fiesta));
        }

        [TestMethod]
        public void TestAbstractHondaFactoryHatchbackInstance()
        {
            IHatchBack hatchBack = hondaFactory.GetHatchBack();
            Assert.IsNotNull(hatchBack);
            Assert.IsInstanceOfType(hatchBack, typeof(Jazz));
        }
        [TestMethod]
        public void TestAbstractHondaFactorySedanInstance()
        {
            ISedan sedan = hondaFactory.GetSedan();
            Assert.IsNotNull(sedan);
            Assert.IsInstanceOfType(sedan, typeof(HondaCity));
        }
    }
}
