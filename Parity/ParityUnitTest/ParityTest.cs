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
        public void IsEven_ShouldReturnTrue_WhenNumberIsEven(int number)
        {
            bool isEven = ParityService.IsEven(number);
            Assert.That(isEven, Is.True);
        }

        [TestCase(2)]
        [TestCase(4)]
        public void IsEven_ShouldReturnFalse_WhenNumberIsDivisibleByTwo(int number)
        {
            bool isEven = ParityService.IsEven(number);
            Assert.That(isEven, Is.False);
        }
    
    }
}