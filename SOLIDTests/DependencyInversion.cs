using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenClosed;
using System.Collections.Generic;
using DependencyInversion;
namespace SOLIDTests
{
    [TestClass]
    public class DependencyInversionTest
    {
        [TestMethod]
        public void TestCustomerAdd()
        {
            INotiificationService notify = new Email();
            Customer cust = new Customer(notify);
            var result = cust.Add();
            Assert.AreEqual(result, true);
        }
    } 
}
