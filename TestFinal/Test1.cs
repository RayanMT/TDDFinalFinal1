using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FinalTDD;

namespace FinalTDDTests
{
    [TestClass]
    public class AverageHelperTests
    {
        [TestMethod]
        public void CalculateAverageYear_ReturnsCorrectAverage()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "ModelA", "MakeA", 2010, "Bus", "OK"),
                new Vehicle("2", "ModelB", "MakeB", 2020, "Truck", "OK")
            };

            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(2015, avg);
        }

        [TestMethod]
        public void CalculateAverageYear_ShouldFail_WhenExpectedIsWrong()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "ModelA", "MakeA", 2010, "Bus", "OK"),
                new Vehicle("2", "ModelB", "MakeB", 2020, "Truck", "OK")
            };

            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(2020, avg); // Intentionally wrong
        }

        [TestMethod]
        public void CalculateAverageYear_EmptyList_ReturnsZero()
        {
            var vehicles = new List<Vehicle>();
            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(0, avg);
        }

        [TestMethod]
        public void CalculateAverageYear_AllSameYear_ReturnsThatYear()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "A", "B", 2015, "Bus", "OK"),
                new Vehicle("2", "C", "D", 2015, "Truck", "OK"),
                new Vehicle("3", "E", "F", 2015, "Private", "OK")
            };

            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(2015, avg);
        }
    }

    [TestClass]
    public class MaintenanceHelperTests
    {
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
        public void CountNeedsService_ShouldFail_WhenExpectedIsWrong()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "A", "B", 2010, "Bus", "OK"),
                new Vehicle("2", "C", "D", 2015, "Truck", "Needs Service")
            };

            int count = MaintenanceHelper.CountNeedsService(vehicles);
            Assert.AreEqual(0, count); // Intentionally wrong
        }
    }

    [TestClass]
    public class SortHelperTests
    {
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
        public void BubbleSort_ShouldFail_WhenOrderIsIncorrectlyExpected()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle("1", "M1", "MF1", 2010, "Bus", "OK"),
                new Vehicle("2", "M2", "MF2", 2020, "Truck", "Needs Service"),
                new Vehicle("3", "M3", "MF3", 2015, "Private", "OK"),
            };

            var sorted = SortHelper.BubbleSort(vehicles);

            Assert.AreEqual(2010, sorted[0].Year); // Intentionally wrong
            Assert.AreEqual(2015, sorted[1].Year);
            Assert.AreEqual(2020, sorted[2].Year);
        }
    }
}
