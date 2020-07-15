using NUnit.Framework;
using LeapYear.Service;

namespace LeapYearTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IfLeapYear_ShouldReturn_True()
        {
            bool isLeap = LeapYears.IsLeapYear(400);
            Assert.That(isLeap, Is.True);
        }
    }
}