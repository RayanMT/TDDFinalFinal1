using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTDD;

namespace FinalTDDTests
{
    [TestClass]
    public class MaintenanceHelperTests
    {
        [TestMethod]
        public void CountNeedsService_WithMixedStatuses_ReturnsCorrectCount()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "ModelA", "MakeA", 2010, "Bus", "OK"),
                new Vehicle("2", "ModelB", "MakeB", 2015, "Truck", "Needs Service"),
                new Vehicle("3", "ModelC", "MakeC", 2020, "Private", "Needs Service")
            };

            int count = MaintenanceHelper.CountNeedsService(vehicles);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void CountNeedsService_WithNoNeedsService_ReturnsZero()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "ModelA", "MakeA", 2010, "Bus", "OK"),
                new Vehicle("2", "ModelB", "MakeB", 2015, "Truck", "OK")
            };

            int count = MaintenanceHelper.CountNeedsService(vehicles);
            Assert.AreEqual(0, count);
        }
    }
}
