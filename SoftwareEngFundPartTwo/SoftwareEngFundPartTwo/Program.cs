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
            OrderOfOperationsNested("hey");
            OrderOfOperationsNested("hello there person");
            OrderOfOperationsNested("|||||||||||||||");
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
