using NUnit.Framework;
using Parity.Library;

namespace ParityUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Function that tests if a number is even or odd
        /// </summary>
        /// <returns>Should return true when number is one</returns>
        [Test]
        public void IsEven_ShouldReturnTrue_WhenNumberIsOne()
        {
            bool isEven = ParityService.IsEven(1);
            Assert.That(isEven, Is.True);
        }
    }
}