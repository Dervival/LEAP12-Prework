﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0 || args[0] == "/?")
            {
                Console.WriteLine("This program expects a direction, bool, and optional integer. Try putting in arguments like 'Left True 4' or 'Up False'.");
                return;
            }
            else if(args.Length < 2)
            {
                Console.WriteLine("Please provide a direction and boolean in the arguments provided.");
            }
            Direction direction;
            if(!Enum.TryParse<Direction>(args[0], out direction))
            {
                Console.WriteLine("The first parameter was not a valid direction, exiting.");
                return;
            }
            bool userInput;
            if(!bool.TryParse(args[1], out userInput))
            {
                Console.WriteLine("The second parameter was not a valid boolean, exiting.");
                return;
            }
            if(Int32.TryParse(args[2], out int optional))
            {
                Console.WriteLine("Arguments provided: " + direction + ", " + userInput + ", " + optional);
            }
            else
            {
                Console.WriteLine("Arguments provided: " + direction + ", " + userInput);
            }
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
            var varDouble = 10.4;
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

        /// <summary>
        /// Function containing the steps pertaining to type conversions in the prework.
        /// </summary>
        static void TypeConversion()
        {
            int x = 10;
            int y = 20;
            int z = 99;
            double a = 12.2;
            double b = 24.79;
            double c = 99999.124124;
            //store integers in the doubles
            a = x;
            b = y;
            c = z;
            //store the doubles in the integers - note explicit casting
            x = (int) a;
            y = (int) b;
            z = (int) c;
        }

        /// <summary>
        /// Function for the work in Strings/Escapes and Literals from prework
        /// </summary>
        static void StringEscapesAndLiterals()
        {
            string stringWithEscapeSequence = "Hello, world!\n\tThis is a single string variable with escape characters in it.";
            Console.WriteLine(stringWithEscapeSequence);
            Console.ReadLine();
            string stringLiteral = @"This is a string literal - escape sequences such as \n, \t, and \\ are ignored and printed directly. This is done by adding a @ character before the double quotes.";
            Console.WriteLine(stringLiteral);
            Console.ReadLine();
        }

        /// <summary>
        /// Function showing how strings can be concatenated with a +
        /// </summary>
        static void StringConcatenation()
        {
            string stringOne = "Hello,";
            string stringTwo = " world!";
            string bothStrings = stringOne + stringTwo;
            Console.WriteLine(bothStrings);
            Console.ReadLine();
        }

        /// <summary>
        /// Function showing how to get and print a string's length
        /// </summary>
        static void StringsWithLength()
        {
            string sampleString = "This is a sample string";
            Console.WriteLine(sampleString + ", of length " + sampleString.Length + ".");
            Console.ReadLine();
        }

        /// <summary>
        /// Shell function for demonstrating string indexing
        /// </summary>
        static void StringIndexing()
        {
            string testString = "AaBbC";
            string firstMiddleLast = ConcatFirstMiddleLast(testString);
            Console.WriteLine("The first, middle, and last characters of " + testString + " are " + firstMiddleLast + ".");
            testString = "Hello everyone!";
            firstMiddleLast = ConcatFirstMiddleLast(testString);
            Console.WriteLine("The first, middle, and last characters of " + testString + " are " + firstMiddleLast + ".");
            Console.ReadLine();
        }

        /// <summary>
        /// Helper function for demonstrating string indexing - returns a string comprised of the first, middle, and last characters of an input string
        /// </summary>
        /// <param name="input">A string whose first, middle, and last characters are to be returned.</param>
        /// <returns>A string containing the first, middle, and last characters of the input.</returns>
        static string ConcatFirstMiddleLast(string input)
        {
            string returnString = "";
            if (string.IsNullOrEmpty(input))
            {
                return returnString;
            }
            returnString += input[0];
            returnString += input[input.Length / 2];
            returnString += input[input.Length - 1];
            return returnString;
        }

        /// <summary>
        /// Function for showing off .ToUpper and .ToLower
        /// </summary>
        static void StringCases()
        {
            string original = "This is a string. It originally has mixed cases.";
            Console.WriteLine(original);
            Console.WriteLine(original.ToUpper());
            Console.WriteLine(original.ToLower());
            Console.ReadLine();
        }

        /// <summary>
        /// Function for showing off getting parts of string via substring and remove
        /// </summary>
        static void GettingPartsOfStrings()
        {
            //Initial partitioning of string via substring
            string stringToPartition = "Ahello worldE";
            string partitionedString = "";
            if(stringToPartition.Length > 1)
            {
                partitionedString = stringToPartition.Substring(1, stringToPartition.Length - 2);
            }
            Console.WriteLine(partitionedString);
            //And a different length being partitioned
            stringToPartition = "<This is fine.>";
            if (stringToPartition.Length > 1)
            {
                partitionedString = stringToPartition.Substring(1, stringToPartition.Length - 2);
            }
            Console.WriteLine(partitionedString);
            //Partitioning the string using .Remove
            stringToPartition = "?Take three, using remove.$";
            if(stringToPartition.Length > 1)
            {
                partitionedString = stringToPartition.Remove(stringToPartition.Length - 1);
                partitionedString = partitionedString.Remove(0, 1);
            }
            Console.WriteLine(partitionedString);
            //Partitioning the string using .Remove with a different length
            stringToPartition = "`And for the last partitioning...Q";
            if (stringToPartition.Length > 1)
            {
                partitionedString = stringToPartition.Remove(stringToPartition.Length - 1);
                partitionedString = partitionedString.Remove(0, 1);
            }
            Console.WriteLine(partitionedString);
            Console.ReadLine();
        }

        /// <summary>
        /// Function for searching strings with IndexOf and Contains
        /// </summary>
        static void SearchingStrings()
        {
            string x = "Welcome to LEAP!";
            char y = 'c';
            int yIndexInX = x.IndexOf(y);
            bool yInX = x.Contains(y);
            string fakePath = @"x:\root\user\foobar.txt";
            char driveLetter = fakePath.ToUpper()[0]; // X
            //getting the filename with no extension is slightly tricky - first remove the extension, then remove everything above the filename in the path, including the slash
            string fileName = fakePath.Remove(fakePath.LastIndexOf('.')); // x:\root\user\foobar
            fileName = fileName.Substring(fileName.LastIndexOf('\\')+1); // foobar
        }

        /// <summary>
        /// Function showing off string.Split()
        /// </summary>
        static void SplittingStrings()
        {
            string x = "This string has spaces in it, which will be split upon.";
            string[] splitX = x.Split(' '); //Split will split a string into an array (or list, or possibly some other ICollection?) of strings by the separator passed in (in this case, a blank space)
        }

        /// <summary>
        /// Function for string.format practice, formatting doubles (?)
        /// </summary>
        static void FormattedStrings()
        {
            const string x = "Hello there {0}, I hope you're having a wonderful {1} today!";
            string y = string.Format(x, "User", "afternoon");
            Console.WriteLine(y);
            double d = 14.1444;
            Console.WriteLine("The double d to two decimal places: " + Math.Round(d, 2));
        }
        
        /// <summary>
        /// Function for playing with parsing different types into strings and out of strings
        /// </summary>
        static void PrintingAndParsingStrings()
        {
            //Initializing a, b, c, d
            bool a = true;
            int b = 17;
            double c = 94.12352;
            char d = 'd';
            //Initializing w, x, y, and z with .ToString()
            string w = a.ToString();
            string x = b.ToString();
            string y = c.ToString();
            string z = d.ToString();
            //creating e, f, g, h from w, x, y, z using TryParse - could initialize in the tryParse itself but then I'd need to deal with scoping issues
            bool e;
            int f;
            double g;
            char h;
            Boolean.TryParse(w, out e);
            Int32.TryParse(x, out f);
            Double.TryParse(y, out g);
            Char.TryParse(z, out h);
        }

        /// <summary>
        /// Function for containing stuff from practicing structs
        /// </summary>
        static void StructPractice()
        {
            Person x = new Person();
            x.firstName = "foo";
            x.lastName = "bar";
            x.age = 999;
            Person y = new Person();
            y.firstName = "Jane";
            y.lastName = "Doe";
            y.age = 24;
            x = y;
            Console.WriteLine("Perso" +
                "n x is " + x.firstName + " " + x.lastName + ", age " + x.age + ".");
        }

        static void ConsoleIOPractice()
        {
            Console.WriteLine("Hello, what is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("And your middle name?");
            string middleName = Console.ReadLine();
            Console.WriteLine("Finally, what is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + firstName + " " + middleName + " " + lastName + "!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    enum Suit
    {
        Hearts,
        Clubs,
        Spades,
        Diamonds
    }

    enum Direction
    {
        Up,
        Right,
        Down,
        Left
    }

    public struct Person
    {
        public string firstName;
        public string lastName;
        public int age;
    }

}
