using System;

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
            PullOddsFromStringWhile();
            PullOddsFromStringDoWhile();
            PullOddsFromStringFor();
            PullOddsFromStringForeach();
        }

        /// <summary>
        /// Basic function to show if/else logic
        /// </summary>
        static void IfElseConditionals()
        {
            int i = 101;
            if( i < 100)
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
            switch(yourPlace)
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
            if((input.Length < 5 && input.Length % 2 == 1) || (input.Length > 10 && input.Length % 2 == 0))
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
            if(input.Length < 5)
            {
                if(input.Length % 2 == 1)
                {
                    Console.WriteLine("The string is either 1 character, 3 characters, or an even number of characters long - " + input.Length);
                }
                else
                {
                    Console.WriteLine("The string is neither 1 character, 3 characters, nor an even number greater than 8 characters long - " + input.Length);
                }
            }
            else if(input.Length > 10)
            {
                if(input.Length % 2 == 0)
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
            while(index < s.Length)
            {
                //This is a bit ugly, but TryParse didn't seem to have an overload for a character in a string using bracket notation, and chars apparently cannot be explicitly cast to strings (but chars can be appended to empty strings!)
                string digit = "";
                digit += s[index];
                Int32.TryParse(digit, out int d);
                if(d % 2 == 1)
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
            for(int i = 0; i < s.Length; i++)
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
            foreach(char c in s)
            {
                string digit = "" + c;
                Int32.TryParse(digit, out int d);
                if(d % 2 == 1)
                {
                    Console.Write(d);
                }
            }
            Console.WriteLine("\n");
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
