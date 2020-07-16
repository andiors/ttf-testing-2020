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
        public void IfInputString_IsEmpty_ReturnZero()
        {
            int stringNumber = StringCalculatorService.Add("");
            Assert.That(stringNumber, Is.EqualTo(0));
        }

        [Test]
        public void IfInputString_IsANumber_ReturnTheEquivalentNumber()
        {
            int stringNumber = StringCalculatorService.Add("1");
            Assert.That(stringNumber, Is.EqualTo(1));
        }
    }
}