using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Builder;
using System.Threading;

namespace CreationalPatternsTest
{
    [TestClass]
    public class BuilderTest
    {
        VehicleCreator creator;

        [TestInitialize]
        public void Init()
        {
            creator = new VehicleCreator(new FordFigoBuilder());
            creator.CreateVehicle();
        }

        [TestMethod]
        public void TestBuilderInstance()
        {
            var vehicle = creator.GetVehicle();
            Assert.IsNotNull(vehicle);
        }

        [TestMethod]
        public void TestBuilderBody()
        {
            
            var vehicle = creator.GetVehicle();
            Assert.AreEqual(vehicle.Body, "HATCH BACK");
        }

        [TestMethod]
        public void TestBuilderDoors()
        {
            var vehicle = creator.GetVehicle();
            Assert.AreEqual(vehicle.Doors, 4);
        }

        [TestMethod]
        public void TestBuilderEngine()
        {
            var vehicle = creator.GetVehicle();
            Assert.AreEqual(vehicle.Engine, "1.4 V Turbo");
        }

        [TestMethod]
        public void TestBuilderModel()
        {
            var vehicle = creator.GetVehicle();
            Assert.AreEqual(vehicle.Model, "Ford Figo");
        }

        [TestMethod]
        public void TestBuilderTranmission()
        {
            var vehicle = creator.GetVehicle();
            Assert.AreEqual(vehicle.Transmission, "5 Gear Manual");
        }

        [TestMethod]
        public void TestBuilderAccessories()
        {
            var vehicle = creator.GetVehicle();
            Assert.AreEqual(vehicle.Accessories.Count, 2);
            Assert.AreEqual(vehicle.Accessories[0], "Glass");
            Assert.AreEqual(vehicle.Accessories[1], "Floor Mats");
        }
    }
}
