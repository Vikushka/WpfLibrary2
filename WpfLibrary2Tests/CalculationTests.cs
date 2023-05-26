using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WpfLibrary2.Tests
{
    [TestClass]
    public class CalculationTests
    {
        
        [TestMethod()]
        public void AvailablePeriodsTest()
        {
            TimeSpan[] startTime = new TimeSpan[] { new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0),
                new TimeSpan(15, 30, 0), new TimeSpan(16, 50, 0) };
            int[] duration = { 60, 30, 10, 10, 40 };
            string[] actual = Calculation.AvailablePeriods(startTime, duration, new TimeSpan(8, 0, 0), new TimeSpan(18, 0, 0), 30);
            string[] expected = new string[] { "08:00-08:30", "08:30-09:00", "08:00-08:30", "09:00-09:30", "09:30-10:00",
                "11:30-12:00", "12:30-13:00", "13:00-13:30", "13:30-14:00", "14:00-14:30", "14:30-15:00", "15:40-16:10", "16:10-16:40", "17:30-18:00" };
            CollectionAssert.Equals(expected, actual);
        }
               
    }
}