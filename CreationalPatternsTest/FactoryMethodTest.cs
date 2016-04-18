using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryMethod;
using System.Threading;

namespace CreationalPatternsTest
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void TestFactoryResumeInstance()
        {
            Document doc = new Resume();
            Assert.IsNotNull(doc);
            Assert.IsInstanceOfType(doc, typeof(Resume));
        }

        [TestMethod]
        public void TestFactoryResumePagesInstance()
        {
            Document doc = new Resume();
            Assert.IsNotNull(doc);
            Assert.IsInstanceOfType(doc, typeof(Resume));
            Assert.AreEqual(doc.Pages.Count, 3);
        }

        [TestMethod]
        public void TestFactoryReportInstance()
        {
            Document doc = new Report();
            Assert.IsNotNull(doc);
            Assert.IsInstanceOfType(doc, typeof(Report));
        }


        [TestMethod]
        public void TestFactoryReportPagesInstance()
        {
            Document doc = new Report();
            Assert.IsNotNull(doc);
            Assert.IsInstanceOfType(doc, typeof(Report));
            Assert.AreEqual(doc.Pages.Count, 2);
        }
    }
}