﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChainOfResponsibility;

namespace BehavioralPatternsTest
{
    [TestClass]
    public class ChainOfResponsibilityTest
    {
        [TestMethod]
        public void TestCORDiscount()
        {
            Product product = new Product(50, 1500);

            Approver storeMgr = new StoreManager();
            Approver areaMgr = new AreaManager();
            Approver countryHead = new CountryHead();

            //Set Successor
            storeMgr.SetSuccessor(areaMgr);
            areaMgr.SetSuccessor(countryHead);

            //Call 1st Process Request
            storeMgr.ProcessDiscountRequest(product);

            //Get Discounted Price
            Assert.AreEqual(product.GetDiscountedPrice(), 1500 - (1500 * (50 / 100)));
        }


        [TestMethod]
        public void TestCORNoDiscount()
        {
            Product product = new Product(55, 1500);

            Approver storeMgr = new StoreManager();
            Approver areaMgr = new AreaManager();
            Approver countryHead = new CountryHead();

            //Set Successor
            storeMgr.SetSuccessor(areaMgr);
            areaMgr.SetSuccessor(countryHead);

            //Call 1st Process Request
            storeMgr.ProcessDiscountRequest(product);

            //Get Discounted Price
            Assert.AreEqual(product.GetDiscountedPrice(), 1500);
        }
    }
}
