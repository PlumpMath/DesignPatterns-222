using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facade;

namespace StructuralPatternsTest
{
    [TestClass]
    public class FacadeTest
    {
        Customer customer;
        HealthInsurance healthInsurance;

        [TestInitialize]
        public void InitObjects()
        {
            customer = new Customer("Prashant", 33, true);
            healthInsurance = new HealthInsurance();
        }
        [TestMethod]
        public void TestFacadeObjectCreation()
        {

            Assert.IsNotNull(customer);
            Assert.IsNotNull(healthInsurance);
        }


        [TestMethod]
        public void TestHealthInsuranceEligibilityWithNonSmoker()
        {
            customer.IsSmoker = false;
            var ret = healthInsurance.IsEligibleForHealthInsurance(customer);
            Assert.AreEqual(ret, true);
        }

        [TestMethod]
        public void TestHealthInsuranceEligibilityWithSmoker()
        {
            customer.IsSmoker = true;
            var ret = healthInsurance.IsEligibleForHealthInsurance(customer);
            Assert.AreEqual(ret, true);
        }

        [TestMethod]
        public void TestHealthInsuranceEligibilityWithAgeGreater60()
        {
            customer.IsSmoker = false;
            customer.Age = 61;
            var ret = healthInsurance.IsEligibleForHealthInsurance(customer);
            Assert.AreEqual(ret, false);
        }

        [TestMethod]
        public void TestHealthInsuranceEligibilityWithAgeLess60()
        {
            customer.IsSmoker = false;
            customer.Age = 59;
            var ret = healthInsurance.IsEligibleForHealthInsurance(customer);
            Assert.AreEqual(ret, true);
        }

        [TestMethod]
        public void TestHealthInsuranceEligibilityWithAgeEquals60()
        {
            customer.IsSmoker = false;
            customer.Age = 60;
            var ret = healthInsurance.IsEligibleForHealthInsurance(customer);
            Assert.AreEqual(ret, true);
        }
    }
}
