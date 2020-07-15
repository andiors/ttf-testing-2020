using NUnit.Framework;
using System.Collections.Generic;
using PrimeFactor.Service;

namespace PrimeFactorsTest
{
    public class PrimeFactorsUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void One_ShouldReturn_NoPrimeFactors()
        {
            List<int> primeFactors = PrimeFactors.Calculate(1);
            Assert.That(primeFactors, Is.Empty);
        }

        [Test]
        public void Two_ShouldReturn_Two()
        {
            List<int> primeFactors = PrimeFactors.Calculate(2);
            List<int> expectedValues = new List<int> { 2 };
           
            Assert.That(primeFactors, Is.EqualTo(expectedValues));
        }

        [Test]
        public void Three_ShouldReturn_Three()
        {
            List<int> primeFactors = PrimeFactors.Calculate(3);
            List<int> expectedValues = new List<int> { 3 };

            Assert.That(primeFactors, Is.EqualTo(expectedValues));
        }

        [Test]
        public void Four_ShouldReturn_TwoTwo()
        {
            List<int> primeFactors = PrimeFactors.Calculate(4);
            List<int> expectedValues = new List<int> { 2, 2 };

            Assert.That(primeFactors, Is.EqualTo(expectedValues));
        }
    }
}