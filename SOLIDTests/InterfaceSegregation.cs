using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenClosed;
using System.Collections.Generic;
using InterfaceSegregation;

namespace SOLIDTests
{
    [TestClass]
    public class InterfaceSegregationTest
    {
        [TestMethod]
        public void TestCustomerAdd()
        {
            List<IDatabase> customers = new List<IDatabase>();
            customers.Add(new Customer());
            
            foreach(var customer in customers)
            {
                Assert.AreEqual(customer.Add(), true);
            }
        }

        [TestMethod]
        public void TestCustomerWithEmail()
        {
            List<IEmailService> customers = new List<IEmailService>();
            customers.Add(new CustomerWithEmails());

            foreach (var customer in customers)
            {
                Assert.AreEqual(customer.SendNotification(), true);
            }
        }

        [TestMethod]
        public void TestCustomerWithRead()
        {
            List<IDatabaseRead> customers = new List<IDatabaseRead>();
            customers.Add(new CustomerWithRead());

            foreach (var customer in customers)
            {
                Assert.AreEqual(customer.ReadCustomer(), 1);
            }
        }
    } 
}
