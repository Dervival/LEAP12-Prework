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
    }
}
