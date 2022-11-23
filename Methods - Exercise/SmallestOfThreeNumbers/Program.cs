using System;
using System.Linq;

namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatingMinValue();
        }

        private static void CalculatingMinValue()
        {
            int[] numbers = new int[3];

            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());



                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            Console.WriteLine(minNumber);
        }

    }
}
