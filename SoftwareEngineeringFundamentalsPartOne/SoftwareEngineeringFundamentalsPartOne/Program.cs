using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OperatorsAssignmentIncrementAndDecrement();
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
        /// This function shows the maximum value for an integer in C#, and what happens when it is overflowed.
        /// </summary>
        static void MinMaxVals()
        {
            int maxInt = int.MaxValue;
            Console.WriteLine("The maximum value for an int is " + maxInt + ".");
            maxInt++;
            Console.WriteLine("Incrementing the maximum value for an int by one results in " + maxInt + ". Notice how it has overflowed to the minimum of an integer value.");
            Console.ReadLine();
        }

        /// <summary>
        /// This function shows how var can be used to make a variable's type to be determined at run-time rather than compile time.
        /// </summary>
        static void ImplicitTypes()
        {
            var varBool = true;
            var varInt = 10;
            var varDouble = 10.4d;
            var varChar = 'X';
            var varString = "Foobar";
            Console.WriteLine("varBool is of type " + varBool.GetType() + " and value " + varBool);
            Console.WriteLine("varInt is of type " + varInt.GetType() + " and value " + varInt);
            Console.WriteLine("varDouble is of type " + varDouble.GetType() + " and value " + varDouble);
            Console.WriteLine("varChar is of type " + varChar.GetType() + " and value " + varChar);
            Console.WriteLine("varString is of type " + varString.GetType() + " and value " + varString);
            Console.ReadLine();
        }

        /// <summary>
        /// This function declares two integers x and y; after initialization, both are manipulated to create two variables via prefix and postfix incrementing. 
        /// </summary>
        static void OperatorsAssignmentIncrementAndDecrement()
        {
            int x = 10;
            int y = 100;
            int z1 = x++;
            int z2 = ++y;
            Console.WriteLine("x is " + x);
            Console.WriteLine("y is " + y);
            Console.WriteLine("z1 is " + z1 + ", which was x++");
            Console.WriteLine("z2 is " + z2 + ", which was ++y");
            Console.ReadLine();
        }

        /// <summary>
        /// Function containing work for the Operators/Math segment of prework
        /// </summary>
        static void OperatorsMath()
        {
            //Declaration of x, y, z
            int x = 10;
            int y = 3;
            int z = 20;
            //Declaration of a, b, and c using x, y, and z
            int a = y - z; //3 - 20 = -17
            int b = z + x; // 20 + 10 = 30
            int c = x / y; // 10 / 3 = 3 (integer division)
            //Expression to see if x is even
            bool isXEven = ((x % 2) == 0);
            //Expression to see if y is not divisible by 3.
            bool isYNotDivisibleByThree = !((y % 3) == 0);
            //Need a double with more than 3 digits precision
            double pi = 3.14159;
            //Expression that rounds a double to 3 decimal places using Math.Round
            double pitToThreePlaces = Math.Round(pi, 3);
        }
    }
}
