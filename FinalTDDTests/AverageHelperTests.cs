using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalTDD;


namespace FinalTDDTests
{
    [TestClass]
    public class AverageHelperTests
    {
        [TestMethod]
        public void CalculateAverageYear_WithValidYears_ReturnsCorrectAverage()
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
        public void CalculateAverageYear_WithEmptyList_ReturnsZero()
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
                new Vehicle("1", "ModelA", "MakeA", 2015, "Bus", "OK"),
                new Vehicle("2", "ModelB", "MakeB", 2015, "Truck", "OK"),
                new Vehicle("3", "ModelC", "MakeC", 2015, "Private", "OK")
            };

            double avg = AverageHelper.CalculateAverageYear(vehicles);
            Assert.AreEqual(2015, avg);
        }
    }
}



