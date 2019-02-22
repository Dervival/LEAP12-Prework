using System;
using System.Collections.Generic;

namespace AlgorithmsPrework
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Checks the given string to see if the first character is repeated elsewhere in the string. Brute-force approach.
        /// </summary>
        /// <param name="toCheck">String to check if the first character is repeated elsewhere.</param>
        /// <returns>True if the first character is found elsewhere in the string, false otherwise.</returns>
        public static bool IsFirstCharRepeated(string toCheck)
        {
            if(toCheck.Length < 1)
            {
                return false;
            }
            char firstChar = toCheck[0];
            for(int i = 1; i < toCheck.Length; i++)
            {
                if(toCheck[i] == firstChar)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Takes in a string and returns a second string that is the reverse of the input string. Iterative approach.
        /// </summary>
        /// <param name="toReverse">String to reverse.</param>
        /// <returns>The reversed input string.</returns>
        public static string ReverseString(string toReverse)
        {
            if(toReverse.Length < 2)
            {
                return toReverse;
            }
            string reversedString = "";
            for(int i = toReverse.Length-1; i >= 0; i--)
            {
                reversedString += toReverse[i];
            }
            return reversedString;
        }

        /// <summary>
        /// Takes in a string and returns a second string that is the reverse of the input string. Recursive approach.
        /// </summary>
        /// <param name="toReverse">String to reverse.</param>
        /// <returns>The reversed input string.</returns>
        public static string ReverseStringRecursion(string toReverse)
        {
            //Base case - if string is one character or less
            if(toReverse.Length < 1)
            {
                return toReverse;
            }
            int trLength = toReverse.Length - 1;
            //Recurse on all but the last character of the string; the last character should be at the front
            return toReverse[trLength] + ReverseStringRecursion(toReverse.Substring(0, trLength));
        }

        /// <summary>
        /// Given a minimum and maximum, iteratively calculates the sum of the integers bounded by those two numbers, inclusively. If the minimum is less than the maximum, returns 0.
        /// </summary>
        /// <param name="min">The first number to start summing.</param>
        /// <param name="max">The last number to start summing.</param>
        /// <returns>The sum of all integers between min and max, inclusive.</returns>
        public static int GetSumBetweenNumbers(int min, int max)
        {
            if(min > max)
            {
                return 0;
            }
            int accum = 0;
            for(int i = min; i <= max; i++)
            {
                accum += i;
            }
            return accum;
        }

        /// <summary>
        /// Given a minimum and maximum, recursively calculates the sum of the integers bounded by those two numbers, inclusively. If the minimum is less than the maximum, returns 0.
        /// </summary>
        /// <param name="min">The first number to start summing.</param>
        /// <param name="max">The last number to start summing.</param>
        /// <returns>The sum of all integers between min and max, inclusive.</returns>
        public static int GetSumBetweenNumbersRecursive(int min, int max)
        {
            if (min > max)
            {
                return 0;
            }
            return min + GetSumBetweenNumbersRecursive(min + 1, max);
        }

        /// <summary>
        /// Given a base x and a exponent y, iteratively calculates x^y.
        /// </summary>
        /// <param name="x">The base to be exponentiated.</param>
        /// <param name="y">The exponent of the expression.</param>
        /// <returns>The value of x^y.</returns>
        public static int XToThePowerOfY(int x, int y)
        {
            int value = x;
            for(int i = 1; i < y; i++)
            {
                value *= x;
            }
            return value;
        }

        /// <summary>
        /// Given a base x and a exponent y, recursively calculates x^y.
        /// </summary>
        /// <param name="x">The base to be exponentiated.</param>
        /// <param name="y">The exponent of the expression.</param>
        /// <returns>The value of x^y.</returns>
        public static int XToThePowerOfYRecursive(int x, int y)
        {
            int value = x;
            //base case - y is 1 or less (since this is integer exponentiation, we can't handle negative or partial exponents)
            if(y < 2)
            {
                return value;
            }
            return value * XToThePowerOfYRecursive(x, y - 1);
        }

        /// <summary>
        /// Given a list of integers, returns the product of all integers in the list. If the list is empty, returns 0.
        /// </summary>
        /// <param name="nums">A list of integers.</param>
        /// <returns>The product of the list of integers.</returns>
        public static int MultiplyList(List<int> nums)
        {
            if(nums.Count == 0)
            {
                return 0;
            }
            int product = 1;
            foreach(int num in nums)
            {
                product *= num;
            }
            return product;
        }

        /// <summary>
        /// Given a list of integers, returns the product of all integers in the list using a divide and conquer strategy. If the list is empty, returns 0.
        /// </summary>
        /// <param name="nums">A list of integers.</param>
        /// <returns>The product of the list of integers.</returns>
        public static int MultiplyListDivideAndConquer(List<int> nums)
        {
            //Base cases - if list is empty, return 0 as above
            if(nums.Count == 0)
            {
                return 0;
            }
            //Since we're divide and conquering, base case of a list with one element needs to be handled
            else if(nums.Count == 1)
            {
                return nums[0];
            }
            //Divide and conquer - break the list into two halves, then recurse through each half. Once the recursion is complete, collapse and multiply the two halves together.
            else
            {
                //Probably a better way to do the splitting and recursion, but this works
                List<int> firstHalf = new List<int>();
                List<int> secondHalf = new List<int>();
                for(int i = 0; i < nums.Count; i++)
                {
                    if(i < nums.Count / 2)
                    {
                        firstHalf.Add(nums[i]);
                    }
                    else
                    {
                        secondHalf.Add(nums[i]);
                    }
                }
                return MultiplyListDivideAndConquer(firstHalf) * MultiplyListDivideAndConquer(secondHalf);
            }
        }
    }
}
