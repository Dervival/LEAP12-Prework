using System;
using System.Collections.Generic;

namespace SoftwareEngFundPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //IfElseConditionals();
            //SwitchLogic();
            //OrderOfOperations("hey");
            //OrderOfOperations("hello there person");
            //OrderOfOperations("|||||||||||||||");
            //OrderOfOperationsNested("hey");
            //OrderOfOperationsNested("hello there person");
            //OrderOfOperationsNested("|||||||||||||||");
            //InfiniteWhileLoop();
            //PullOddsFromStringWhile();
            //PullOddsFromStringDoWhile();
            //PullOddsFromStringFor();
            //PullOddsFromStringForeach();
            //FindFirstCharacterLaterInString();
            //SingleDimensionArrays();
            //MultiDimensionalArrays();

            //Basic functions
            PrintFunction("Hello world!"); //#1
            Console.WriteLine(ConcatForPrint("Hello", ", ", "world!")); //#2
            int[] testArray = { 1, 5, 3 }; //initialization of #3
            UpdateAtIndex(testArray, 1, 2); //#3
            Console.WriteLine(testArray[1]); //verifying #3
            Console.WriteLine(RemoveEvenWords("Hello there, how are you doing today?")); //#4 - returns "Hello how you today?"
            Console.WriteLine(CustomSubstring("foobar", 2)); //#5 - returns "obar"
        }

        /// <summary>
        /// Basic function to show if/else logic
        /// </summary>
        static void IfElseConditionals()
        {
            int i = 101;
            if (i < 100)
            {
                Console.WriteLine("i is less than 100");
            }
            else if (i == 100)
            {
                Console.WriteLine("i equals 100");
            }
            else
            {
                Console.WriteLine("i is greater than 100");
            }
        }

        /// <summary>
        /// Function for demonstrating switch statements
        /// </summary>
        static void SwitchLogic()
        {
            Placement yourPlace = Placement.First;
            switch (yourPlace)
            {
                case Placement.First:
                    Console.WriteLine("Congratulations, you won!");
                    break;
                case Placement.Second:
                    Console.WriteLine("Congratulations, you came in second.");
                    break;
                case Placement.Third:
                    Console.WriteLine("Well done, you got third place.");
                    break;
                case Placement.Fourth:
                case Placement.Finalist:
                    Console.WriteLine("Good job on making it into the finals!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, you didn't even place.");
                    break;
            }

        }

        /// <summary>
        /// Function for demonstrating order of operations using conditional operators
        /// </summary>
        /// <param name="input">String whose length is being checked against</param>
        static void OrderOfOperations(string input)
        {
            if ((input.Length < 5 && input.Length % 2 == 1) || (input.Length > 10 && input.Length % 2 == 0))
            {
                Console.WriteLine("The string is either 1 character, 3 characters, or an even number of characters long - " + input.Length);
            }
            else
            {
                Console.WriteLine("The string is neither 1 character, 3 characters, nor an even number greater than 8 characters long - " + input.Length);
            }
        }

        /// <summary>
        /// Function for demonstrating order of operations using nested conditionals
        /// </summary>
        /// <param name="input">String whose length is being checked against</param>
        static void OrderOfOperationsNested(string input)
        {
            if (input.Length < 5)
            {
                if (input.Length % 2 == 1)
                {
                    Console.WriteLine("The string is either 1 character, 3 characters, or an even number of characters long - " + input.Length);
                }
                else
                {
                    Console.WriteLine("The string is neither 1 character, 3 characters, nor an even number greater than 8 characters long - " + input.Length);
                }
            }
            else if (input.Length > 10)
            {
                if (input.Length % 2 == 0)
                {
                    Console.WriteLine("The string is either 1 character, 3 characters, or an even number of characters long - " + input.Length);
                }
                else
                {
                    Console.WriteLine("The string is neither 1 character, 3 characters, nor an even number greater than 8 characters long - " + input.Length);
                }
            }
            else
            {
                Console.WriteLine("The string is neither 1 character, 3 characters, nor an even number greater than 8 characters long - " + input.Length);
            }
        }

        /// <summary>
        /// Function for showing an infinite while loop.
        /// </summary>
        static void InfiniteWhileLoop()
        {
            while (true)
            {
                //creates an infinite loop
            }
        }

        /// <summary>
        /// Function for pulling digits pertaining to odd numbers out of a string, using a while loop. There's probably a better way than using bracket notation and forcing the character into a string, but this seems to work.
        /// </summary>
        static void PullOddsFromStringWhile()
        {
            string s = "0123456789";
            int index = 0;
            while (index < s.Length)
            {
                //This is a bit ugly, but TryParse didn't seem to have an overload for a character in a string using bracket notation, and chars apparently cannot be explicitly cast to strings (but chars can be appended to empty strings!)
                string digit = "";
                digit += s[index];
                Int32.TryParse(digit, out int d);
                if (d % 2 == 1)
                {
                    Console.Write(d);
                }
                index++;
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Function for pulling odd number digits out of a string using a do...while loop.
        /// </summary>
        static void PullOddsFromStringDoWhile()
        {
            string s = "0123456789";
            int index = 0;
            do
            {
                string digit = "";
                digit += s[index];
                Int32.TryParse(digit, out int d);
                if (d % 2 == 1)
                {
                    Console.Write(d);
                }
                index++;
            }
            while (index < s.Length);
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Function for pulling odd number digits out of a string using a for loop.
        /// </summary>
        static void PullOddsFromStringFor()
        {
            string s = "0123456789";
            for (int i = 0; i < s.Length; i++)
            {
                string digit = "";
                digit += s[i];
                Int32.TryParse(digit, out int d);
                if (d % 2 == 1)
                {
                    Console.Write(d);
                }
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Function for pulling odd number digits out of a string using a foreach loop. Strings are a collection of characters!
        /// </summary>
        static void PullOddsFromStringForeach()
        {
            string s = "0123456789";
            foreach (char c in s)
            {
                string digit = "" + c;
                Int32.TryParse(digit, out int d);
                if (d % 2 == 1)
                {
                    Console.Write(d);
                }
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Function demonstrating loop flow control
        /// </summary>
        static void FindFirstCharacterLaterInString()
        {
            string test = "test string";
            char charToFind = test[0];
            for (int i = 1; i < test.Length; i++)
            {
                if (test[i] == charToFind)
                {
                    Console.WriteLine("character " + charToFind + " found at index " + i);
                    break;
                }
            }
        }

        /// <summary>
        /// Function demonstrating one-dimensional (integer) arrays
        /// </summary>
        static void SingleDimensionArrays()
        {
            //initializing the array
            int[] singleArray = new int[10];
            int i = 0;
            while(i < singleArray.Length)
            {
                singleArray[i] = ++i; 
            }
            //printing it in reverse order
            int accum = 0;
            for(int j = singleArray.Length -1; j >= 0; j--)
            {
                Console.Write(singleArray[j] + " ");
                accum += singleArray[j];
            }
            Console.WriteLine();
            //printing the sum
            Console.WriteLine("Sum of array: " + accum);
            //printing the contents with no explicit loop
            string arrayContents = string.Join(" ", singleArray);
            Console.WriteLine(arrayContents);
        }

        /// <summary>
        /// Function for showing off 2D arrays
        /// </summary>
        static void MultiDimensionalArrays()
        {
            int[][] multArray = new int[12][];
            for(int i = 0; i < multArray.Length; i++)
            {
                //using jagged array nomenclature for the multi-dimensional array; need to instantiate the rows as new arrays
                multArray[i] = new int[12];
                for(int j = 0; j < multArray[i].Length; j++)
                {
                    multArray[i][j] = i * j;
                }
            }
            foreach (int[] row in multArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        /// <summary>
        /// Prints out a message passed in as an argument.
        /// </summary>
        /// <param name="message">String to be printed out.</param>
        static void PrintFunction(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Concatenates and returns three strings.
        /// </summary>
        /// <param name="s1">Base string to add to.</param>
        /// <param name="s2">First string to concatenate to the base string.</param>
        /// <param name="s3">Second string to concatenate to the base string.</param>
        /// <returns>A concatenated string of all arguments.</returns>
        static string ConcatForPrint(string s1, string s2, string s3)
        {
            return s1 + s2 + s3;
        }

        /// <summary>
        /// Updates the given integer array with the given value at the provided index. If the index is out of range, does nothing.
        /// </summary>
        /// <param name="array">Array to be modified.</param>
        /// <param name="index">Index of array where modification is to occur.</param>
        /// <param name="value">Value to update the array with.</param>
        static void UpdateAtIndex(int[] array, int index, int value)
        {
            if(index < 0 || index >= array.Length)
            {
                return;
            }
            array[index] = value;
        }

        static string RemoveEvenWords(string message)
        {
            string oddWords = "";
            string[] wordsArray = message.Split(" ");
            for(int i = 0; i < wordsArray.Length; i++)
            {
                if(i%2 == 0)
                {
                    oddWords += wordsArray[i] + " ";
                }
            }
            //removing the trailing space...
            oddWords.Remove(oddWords.Length - 1);
            return oddWords;
        }

        static string CustomSubstring(string message, int index = 0, int length = 0)
        {
            //Invalid index or length
            if(index < 0 || length < 0 || index >= message.Length)
            {
                return "";
            }
            //Length not provided or substring would go past end of the string
            if(length == 0 || index + length > message.Length)
            {
                return message.Substring(index);
            }
            //Else return the desired substring
            return message.Substring(index, length);
        }
    }
    enum Placement
    {
        First,
        Second,
        Third,
        Fourth,
        Finalist,
    }
}
