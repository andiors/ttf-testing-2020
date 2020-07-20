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

        [Test]
        public void TwoNumbers_SeparatedByComma_ShouldReturn_TheirSum()
        {
            int stringNumber = StringCalculatorService.Add("1,2");
            Assert.That(stringNumber, Is.EqualTo(3));
        }

        [TestCase("5,8,2,4,4,9")]
        [TestCase("5,8,2\n4\n4,9")]
        [TestCase("5\n8,2\n4\n4\n9")]
        
        public void ReturnTheSum_WhenInputString_AreAListOfNumber(string numbersSet)
        {
            int stringNumber = StringCalculatorService.Add(numbersSet);
            Assert.That(stringNumber, Is.EqualTo(32));
        }
        
        [TestCase("//n5񙓦񘄸�9")]
        [TestCase("//*\n5*8*2*4*4*9")]
        public void ReturnTheSum_OfAListOfNumber_WithCustomSeparator(string numberSet)
        {
            int stringNumber = StringCalculatorService.Add(numberSet);
            Assert.That(stringNumber, Is.EqualTo(32));
        }

        [TestCase("-2")]
        [TestCase("-3")]
        public void ThrowsAnException_IfInputString_IsANegativeNumber(string negativeNumber)
        {
            Assert.That(() => StringCalculatorService.Add(negativeNumber),
                Throws.InstanceOf(typeof(InvalidOperationException)));
        }
    }
}