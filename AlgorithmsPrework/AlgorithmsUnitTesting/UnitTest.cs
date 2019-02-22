using System;
using Xunit;
using AlgorithmsPrework;

namespace AlgorithmsUnitTesting
{
    public class UnitTest
    {
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
    }
}
