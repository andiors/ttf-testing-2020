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
            bool isLeap = LeapYears.IsLeapYear(1548);
            Assert.That(isLeap, Is.True);
        }

        [TestCase(100)]
        [TestCase(1300)]
        public void IfIsSecolarYear_ShouldReturnFalse(int year)
        {
            bool isLeap = LeapYears.IsLeapYear(year);
            Assert.That(isLeap, Is.False);
        }

        [TestCase(400)]
        [TestCase(2000)]
        [TestCase(1600)]
        public void IfSecolarYear_DivisibleBy400_ShouldReturnTrue(int year)
        {
            bool isLeap = LeapYears.IsLeapYear(year);
            Assert.That(isLeap, Is.True);
        }

        public void InGiulianCalendar_IfYearIsDivisibleBy4_ShouldReturnTrue()
        {
            bool isLeap = LeapYears.IsLeapYear(1744);
            Assert.That(isLeap, Is.True);
        }
        
    }
}