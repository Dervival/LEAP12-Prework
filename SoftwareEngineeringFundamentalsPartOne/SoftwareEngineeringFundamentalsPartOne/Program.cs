using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Variables();
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
            bool IsTrue = true;
            int IntOne = 1;
            double DoubleOnePointFive = 1.5d;
            char Char = 'A';
            string StringOne = "One";
            Console.WriteLine("Istrue is: " + IsTrue);
            Console.WriteLine("IntOne is: " + IntOne);
            Console.WriteLine("DoubleOnePointFive is: " + DoubleOnePointFive);
            Console.WriteLine("Char is: " + Char);
            Console.WriteLine("StringOne is: " + StringOne);
            Console.ReadLine();
        }
    }
}
