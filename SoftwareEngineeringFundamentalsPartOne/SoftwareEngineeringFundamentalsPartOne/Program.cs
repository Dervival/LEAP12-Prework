using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MinMaxVals();
        }

        /// <summary>
        /// A basic function filled with a single-line comment, a block comment, and an XML documentaiton style comment.
        /// </summary>
        static void Comments()
        {
            //This is a single line comment.
            /*This is a multi-line comment block.
             * See how it stretches between different lines?
             * Remember to truncate with an asterisk-slash*/
            /// <fakeXML>
            /// XML Documentation Comments can be created with triple slashes, with XML tags giving meta information about the text enclosed.
            /// </fakeXML>
        }

        /// <summary>
        /// This function declares a bool, int, double, char, and string with initial values and prints them to the console.
        /// </summary>
        static void Variables()
        {
            bool isTrue = true;
            int intOne = 1;
            double doubleOnePointFive = 1.5d;
            char character = 'A';
            string stringOne = "One";
            Console.WriteLine("Istrue is: " + isTrue);
            Console.WriteLine("IntOne is: " + intOne);
            Console.WriteLine("DoubleOnePointFive is: " + doubleOnePointFive);
            Console.WriteLine("Char is: " + character);
            Console.WriteLine("StringOne is: " + stringOne);
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        static void MinMaxVals()
        {
            int maxInt = int.MaxValue;
            Console.WriteLine("The maximum value for an int is " + maxInt + ".");
            maxInt++;
            Console.WriteLine("Incrementing the maximum value for an int by one results in " + maxInt + ".");
            Console.ReadLine();
        }
    }
}
