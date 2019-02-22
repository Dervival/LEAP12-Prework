using System;
using Xunit;
using AlgorithmsPrework;

namespace AlgorithmsUnitTesting
{
    public class UnitTest
    {
        //Brute force (IsFirstCharRepeated) tests
        [Fact]
        public void IsFirstCharRepeatedReturnsTrueIfFirstCharIsInStringTwice()
        {
            Assert.True(Program.IsFirstCharRepeated("haha"));
        }

        [Fact]
        public void IsFirstCharRepeatedReturnsFalseIfFirstCharIsUnique()
        {
            Assert.False(Program.IsFirstCharRepeated("ABCDEFGH"));
        }

        [Fact]
        public void IsFirstCharRepeatedReturnsFalseOnEmptyString()
        {
            Assert.False(Program.IsFirstCharRepeated(""));
        }

        //Recursion - ReverseString tests
        [Fact]
        public void ReverseStringActsAsExpectedOnOddLengthString()
        {
            Assert.Equal("olleH", Program.ReverseString("Hello"));
        }

        [Fact]
        public void ReverseStringActsAsExpectedOnEvenLengthString()
        {
            Assert.Equal("PAEL", Program.ReverseString("LEAP"));
        }

        [Fact]
        public void ReverseStringRecursionActsAsExpectedOnOddLengthString()
        {
            Assert.Equal("olleH", Program.ReverseStringRecursion("Hello"));
        }

        [Fact]
        public void ReverseStringRecursionActsAsExpectedOnEvenLengthString()
        {
            Assert.Equal("PAEL", Program.ReverseStringRecursion("LEAP"));
        }

        //Recursion - GetSumBetweenNumbers tests
        [Fact]
        public void GetSumBetweenNumbersWorksAsExpectedWithValidCase()
        {
            Assert.Equal(55, Program.GetSumBetweenNumbers(1, 10));
        }

        [Fact]
        public void GetSumBetweenNumbersReturnsZeroWithInvalidMinMax()
        {
            Assert.Equal(0, Program.GetSumBetweenNumbers(10, 1));
        }

        [Fact]
        public void GetSumBetweenNumbersRecursiveWorksAsExpectedWithValidCase()
        {
            Assert.Equal(55, Program.GetSumBetweenNumbersRecursive(1, 10));
        }

        [Fact]
        public void GetSumBetweenNumbersRecursiveReturnsZeroWithInvalidMinMax()
        {
            Assert.Equal(0, Program.GetSumBetweenNumbersRecursive(10, 1));
        }

        //Recursion - XToThePowerOfY tests
        [Fact]
        public void XToThePowerOfYReturnsCorrectValue()
        {
            Assert.Equal(8, Program.XToThePowerOfY(2, 3));
        }

        [Fact]
        public void XToThePowerOfYRecursiveReturnsCorrectValue()
        {
            Assert.Equal(8, Program.XToThePowerOfYRecursive(2, 3));
        }
    }
}
