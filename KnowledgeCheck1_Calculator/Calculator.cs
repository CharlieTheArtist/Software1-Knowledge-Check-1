using System;

namespace KnowledgeCheck1_Calculator
{
    //Made class static so that methods could be called without instatiation
    public static class Calculator
    {
        public static void Add(int first, int second)
        {
            Console.WriteLine($"{first} + {second} = {first + second} ");
        }

        public static void Subtract(int first, int second)
        {
            Console.WriteLine($"{first} - {second} = {first - second} ");
        }

        public static void Multiply(int first, int second)
        {
            Console.WriteLine($"{first} * {second} = {first * second} ");
        }

        public static void Divide(double first, double second)
        {
            Console.WriteLine($"{first} / {second} = {first / second} ");

        }

        //captures inputs, parses them, signals true if successful
        public static bool CaptureValues(string operation, out int valueOne, out int valueTwo)
        {
            //capture inputs, pass the operation
            Console.WriteLine($"Enter 2 integers to {operation}");
            Console.WriteLine("Please enter your first number.");
            string inputOne = Console.ReadLine();
            Console.WriteLine("Please enter your second number.");
            string inputTwo = Console.ReadLine();

            //check if they parse correctly
            bool isParsedOne = int.TryParse(inputOne, out valueOne);
            bool isParsedTwo = int.TryParse(inputTwo, out valueTwo);

            return isParsedOne && isParsedTwo;

        }


        //Method overload to handle doubles.
        public static bool CaptureValues(string operation, out double valueOne, out double valueTwo)
        {
            Console.WriteLine($"Enter 2 integers to {operation}");
            Console.WriteLine("Please enter your first number.");
            string inputOne = Console.ReadLine();
            Console.WriteLine("Please enter your second number.");
            string inputTwo = Console.ReadLine();

            bool isParsedOne = double.TryParse(inputOne, out valueOne);
            bool isParsedTwo = double.TryParse(inputTwo, out valueTwo);

            return isParsedOne && isParsedTwo;
        }

    }
}
