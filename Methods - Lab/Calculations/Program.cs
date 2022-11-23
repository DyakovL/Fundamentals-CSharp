using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(numOne, numTwo);

            }
            else if (command == "multiply")
            {
                Multiply(numOne, numTwo);
            }
            else if (command == "subtract")
            {
                Subtract(numOne, numTwo);
            }
            else if (command == "divide")
            {
                Divide(numOne, numTwo);
            }



        }

        private static void Add(int numOne, int numTwo)
        {
            int result = numOne + numTwo;
            Console.WriteLine(result);
        }

        private static void Multiply(int numOne, int numTwo)
        {
            int result = (numOne * numTwo);
            Console.WriteLine(result);
        }

        private static void Subtract(int numOne, int numTwo)
        {
            int result = (numOne - numTwo);
            Console.WriteLine(result);
        }

        private static void Divide(int numOne, int numTwo)
        {
            double result = (double)(numOne / numTwo);
            Console.WriteLine(result);
        }
    }
}
