using System;
using Xunit;
using AlgorithmsPrework;
using System.Collections.Generic;

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

        //Divide and Conquer - MultiplyList tests
        [Fact]
        public void MultiplyListHandlesArbitraryEvenList()
        {
            List<int> integers = new List<int> { 1, 5, 6, 2 };
            Assert.Equal(60, Program.MultiplyList(integers));
        }
        [Fact]
        public void MultiplyListHandlesArbitraryOddList()
        {
            List<int> integers = new List<int> { 1, 5, 6, 2, 9 };
            Assert.Equal(540, Program.MultiplyList(integers));
        }

        [Fact]
        public void MultiplyListHandlesEmptyListGracefully()
        {
            List<int> emptyList = new List<int>();
            Assert.Equal(0, Program.MultiplyList(emptyList));
        }

        [Fact]
        public void MultiplyListDivideAndConquerHandlesArbitraryEvenList()
        {
            List<int> integers = new List<int> { 1, 5, 6, 2 };
            Assert.Equal(60, Program.MultiplyListDivideAndConquer(integers));
        }

        [Fact]
        public void MultiplyListDivideAndConquerHandlesArbitraryOddList()
        {
            List<int> integers = new List<int> { 1, 5, 6, 2, 9 };
            Assert.Equal(540, Program.MultiplyListDivideAndConquer(integers));
        }

        [Fact]
        public void MultiplyListDivideAndConquerHandlesEmptyListGracefully()
        {
            List<int> emptyList = new List<int>();
            Assert.Equal(0, Program.MultiplyListDivideAndConquer(emptyList));
        }

        //Greedy - FillRoomWithBoxes tests
        [Fact]
        public void FillRoomWithBoxesInitialExample()
        {
            int roomSize = 25;
            List<int> sizes = new List<int> { 7, 3, 1 };
            List<int> boxes = new List<int>();
            Program.FillRoomWithBoxes(roomSize, sizes, boxes);
            List<int> expectedBoxes = new List<int> { 7, 7, 7, 3, 1 };
            Assert.Equal(expectedBoxes, boxes);
        }

        [Fact]
        public void FillRoomWithBoxesReturnsEmptyListIfAllSizesTooBig()
        {
            int roomSize = 2;
            List<int> sizes = new List<int> { 9, 5, 3 };
            List<int> boxes = new List<int>();
            Program.FillRoomWithBoxes(roomSize, sizes, boxes);
            List<int> expected = new List<int>();
            Assert.Equal(expected, boxes);
        }
    }
}
