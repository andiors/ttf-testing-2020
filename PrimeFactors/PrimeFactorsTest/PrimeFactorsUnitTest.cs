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

       
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 2, 2)]
        [TestCase(5, 5)]
        public void PrimeFactors_ShouldReturn(int number, params int[] expectedFactors)
        {
            List<int> primeFactors = PrimeFactors.Calculate(number);
            Assert.That(primeFactors, Is.EqualTo(expectedFactors));
        }

        
    }
}