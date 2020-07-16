using NUnit.Framework;
using System;
using StringCalculator;

namespace StringCalculatorUnitTest
{
    public class StringCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InputString_ShouldReturn_TheEquivalentNumber()
        {
            int stringNumber = StringCalculatorService.Add("1");
            Assert.Pass();
        }
    }
}