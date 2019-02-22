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
    }
}
