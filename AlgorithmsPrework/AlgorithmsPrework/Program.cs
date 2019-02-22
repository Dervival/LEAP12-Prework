using System;

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
    }
}
