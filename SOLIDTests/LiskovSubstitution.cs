using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenClosed;
using System.Collections.Generic;
using LiskovSubstitution;

namespace SOLIDTests
{
    [TestClass]
    public class LiskovSubstituionTest
    {
        [TestMethod]
        public void TestGoldCustomerAdd()
        {
            List<IDatabase> customers = new List<IDatabase>();
            customers.Add(new GoldCustomer());
            
            foreach(var customer in customers)
            {
                Assert.AreEqual(customer.Add(), true);
            }
        }

        [TestMethod]
        public void TestGoldCustomerDiscount()
        {
            List<IDiscount> customers = new List<IDiscount>();
            customers.Add(new GoldCustomer());
            customers.Add(new Enquiry());
            double total = 0;
            
            foreach (var customer in customers)
            {
                total += customer.GetDiscount(200);
            }

            Assert.AreEqual(total, 250);
        }
   } 
}
