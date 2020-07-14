using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(5149)]
        [TestCase(-13)]
        public void IsEven_ShouldReturnTrue_WhenNumberIsNotDivisibleByTwo(int number)
        {
            bool isEven = ParityService.IsEven(number);
            Assert.That(isEven, Is.True);
        }

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(4896)]
        [TestCase(-679634)]
        [TestCase(0)]
        public void IsEven_ShouldReturnFalse_WhenNumberIsDivisibleByTwo(int number)
        {
            bool isEven = ParityService.IsEven(number);
            Assert.That(isEven, Is.False);
        }
    
    }
}