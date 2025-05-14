using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FinalTDD;

namespace FinalTDDTests
{
    [TestClass]
    public class SortHelperTests
    {
        [TestMethod]
        public void BubbleSort_SortsByYearDescending()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "Model1", "Make1", 2010, "Bus", "OK"),
                new Vehicle("2", "Model2", "Make2", 2020, "Truck", "Needs Service"),
                new Vehicle("3", "Model3", "Make3", 2015, "Private", "OK")
            };

            var sorted = SortHelper.BubbleSort(vehicles);

            Assert.AreEqual(2020, sorted[0].Year);
            Assert.AreEqual(2015, sorted[1].Year);
            Assert.AreEqual(2010, sorted[2].Year);
        }

        [TestMethod]
        public void BubbleSort_WithSameYears_KeepsOrderAmongEquals()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "Model1", "Make1", 2015, "Bus", "OK"),
                new Vehicle("2", "Model2", "Make2", 2015, "Truck", "Needs Service"),
                new Vehicle("3", "Model3", "Make3", 2015, "Private", "OK")
            };

            var sorted = SortHelper.BubbleSort(vehicles);
            Assert.AreEqual(2015, sorted[0].Year);
            Assert.AreEqual(2015, sorted[1].Year);
            Assert.AreEqual(2015, sorted[2].Year);
        }
    }
}
}

