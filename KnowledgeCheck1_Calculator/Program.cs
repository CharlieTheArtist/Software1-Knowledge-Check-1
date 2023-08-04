using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division.");
            Console.WriteLine(" Type exit to quit.");

            var input = Console.ReadLine();
            int valueOne;
            int valueTwo;
            string operation = " ";
            

            while (input.ToLower() != "exit")
            {
                switch (input)
                {
                    case "1":
                        //Each case runs in the same format
                        //Operation identifier plugs into console.writeline output
                        operation = "add. ";

                        //calls CaptureValues method and checks if returns true, if so runs the calculator method to perform the operation
                        if (Calculator.CaptureValues(operation, out valueOne, out valueTwo))
                        {
                            Calculator.Add(valueOne, valueTwo);
                        }
                        else Console.WriteLine("One or more of the numbers is not an int");

                        break;

                    case "2":
                        operation = "subtract. ";

                        if (Calculator.CaptureValues(operation, out valueOne, out valueTwo))
                        {
                            Calculator.Subtract(valueOne, valueTwo);
                        }
                        else Console.WriteLine("One or more of the numbers is not an int");

                        break;

                    case "3":
                        operation = "multiply. ";

                        if (Calculator.CaptureValues(operation, out valueOne, out valueTwo))
                        {
                            Calculator.Multiply(valueOne, valueTwo);
                        }
                        else Console.WriteLine("One or more of the numbers is not an int");

                        break;

                    case "4":
                        operation = "divide. ";

                        if (Calculator.CaptureValues(operation, out valueOne, out valueTwo))
                        {
                            Calculator.Divide(valueOne, valueTwo);
                        }
                        else Console.WriteLine("One or more of the numbers is not a double");

                        break;

                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }

                Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division.");
                Console.WriteLine("Type exit to quit.");

                input = Console.ReadLine();
            }
        }
    }
}s