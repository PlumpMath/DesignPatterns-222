using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;
using System.Threading;

namespace CreationalPatternsTest
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void TestSingletonInstanceEquals()
        {
            LazySingleton obj = LazySingleton.Instance;
            LazySingleton obj2 = LazySingleton.Instance;
            Assert.AreEqual(obj, obj2);
        }

        [TestMethod]
        public void TestStaticSingletonInstanceEquals()
        {
            StaticSingleton obj = StaticSingleton.Instance;
            StaticSingleton obj2 = StaticSingleton.Instance;
            Assert.AreEqual(obj, obj2);
        }


        [TestMethod]
        public void TestMultiThreadedSingletonInstanceEquals()
        {
            MultiThreadedSingleton obj = MultiThreadedSingleton.Instance;
            MultiThreadedSingleton obj2 = MultiThreadedSingleton.Instance;
            Assert.AreEqual(obj, obj2);
        }

        [TestMethod]
        public void TestDotnetLazySingletonInstanceEquals()
        {
            DotnetLazySingleton obj = DotnetLazySingleton.Instance;
            DotnetLazySingleton obj2 = DotnetLazySingleton.Instance;
            Assert.AreEqual(obj, obj2);
        }
    }
}
