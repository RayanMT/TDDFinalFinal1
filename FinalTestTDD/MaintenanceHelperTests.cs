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
        // ✅ PASS: Correctly counts 2 needing service
        [TestMethod]
        public void CountNeedsService_ReturnsCorrectCount()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "A", "B", 2010, "Bus", "OK"),
                new Vehicle("2", "C", "D", 2015, "Truck", "Needs Service"),
                new Vehicle("3", "E", "F", 2020, "Private", "Needs Service")
            };

            int count = MaintenanceHelper.CountNeedsService(vehicles);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void CountNeedsService_ShouldReturnCorrectCount_WhenGivenValidInput()
        {
            var vehicles = new List<Vehicle>
    {
        new Vehicle("1", "A", "B", 2010, "Bus", "OK"),
        new Vehicle("2", "C", "D", 2015, "Truck", "Needs Service")
    };

            int count = MaintenanceHelper.CountNeedsService(vehicles);
            Assert.AreEqual(1, count); // ✅ Fixed Expected Value
        }

    }
}
