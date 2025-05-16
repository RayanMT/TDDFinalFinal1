﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FinalTDD;

namespace FinalTDDTests
{
    [TestClass]
    public class SortHelperTests
    {
        // ✅ PASS: Correct descending sort
        [TestMethod]
        public void BubbleSort_SortsVehiclesByYearDescending()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "M1", "MF1", 2010, "Bus", "OK"),
                new Vehicle("2", "M2", "MF2", 2020, "Truck", "Needs Service"),
                new Vehicle("3", "M3", "MF3", 2015, "Private", "OK"),
            };

            var sorted = SortHelper.BubbleSort(vehicles);

            Assert.AreEqual(2020, sorted[0].Year);
            Assert.AreEqual(2015, sorted[1].Year);
            Assert.AreEqual(2010, sorted[2].Year);
        }

        [TestMethod]
        public void BubbleSort_ShouldReturnVehiclesSortedByYearDescending()
        {
            var vehicles = new List<Vehicle>
    {
        new Vehicle("1", "M1", "MF1", 2010, "Bus", "OK"),
        new Vehicle("2", "M2", "MF2", 2020, "Truck", "Needs Service"),
        new Vehicle("3", "M3", "MF3", 2015, "Private", "OK"),
    };

            var sorted = SortHelper.BubbleSort(vehicles);

            Assert.AreEqual(2020, sorted[0].Year); // ✅ Fixed Order
            Assert.AreEqual(2015, sorted[1].Year); // ✅ Fixed Order
            Assert.AreEqual(2010, sorted[2].Year); // ✅ Fixed Order
        }

    }
}
