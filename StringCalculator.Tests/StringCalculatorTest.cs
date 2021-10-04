

using NUnit.Framework;
using System;

namespace StringCalculator.Tests
{
    public class StringCalculatorTest
    {

        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            Assert.AreEqual(0, StringCalculator.Add(string.Empty));
        }

        [Test]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {
            Assert.AreEqual(3, StringCalculator.Add("3"));
        }

        [Test]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "5,6";
            var expectedResult = 11;
            Assert.AreEqual(expectedResult, StringCalculator.Add(numbers));
        }

        [Test]
        public void Add_ThreeNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "1, 2, 3";
            var expected = 6;
            Assert.AreEqual(expected, StringCalculator.Add(numbers));
        }

        [TestCase("1,2,3,5", 11)]
        [TestCase("1,2,3,4,5", 15)]
        public void Add_MoreThanThreeNumbersSeparatedByComma_ReturnsTheirSum(
            string input, int result)
        {
            Assert.AreEqual(result, StringCalculator.Add(input));
        }

        [TestCase("-1,1,2,3")]
        [TestCase("4,5,-5")]
        public void Add_StringContainingNegativeNumbers_Throws(string numbers)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }

    }
}
