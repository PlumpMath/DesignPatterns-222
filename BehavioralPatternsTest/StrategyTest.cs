using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy;

namespace BehavioralPatternsTest
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void TestStrategyValueAddedTax()
        {
            ProductTax productTax = new ValueAddedTax();
            Product product = new Product(productTax);
            const int price = 100;
            const double taxRate = 5;
            //Get Price with Value Added Tax
            Assert.AreEqual(product.GetTax(price), ((taxRate / 100) * price));
        }
        [TestMethod]
        public void TestStrategyDirectTax()
        {
            ProductTax productTax = new DirectTax();
            Product product = new Product(productTax);
            const int price = 100;
            const double taxRate = 10;
            //Get Price with Value Added Tax
            Assert.AreEqual(product.GetTax(price), ((taxRate / 100) * price));
        }

        [TestMethod]
        public void TestStrategyInDirectTax()
        {
            ProductTax productTax = new InDirectTax();
            Product product = new Product(productTax);
            const int price = 100;
            const double taxRate = 2.5;
            //Get Price with Value Added Tax
            Assert.AreEqual(product.GetTax(price), ((taxRate / 100) * price));
        }
    }
}
