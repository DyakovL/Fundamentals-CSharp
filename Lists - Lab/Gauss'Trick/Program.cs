using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < number.Count / 2; i++)
            {
                int currentSum = number[i] + number[number.Count - 1 - i];

                result.Add(currentSum);

            }

            if (number.Count % 2 != 0)
            {
                result.Add(number[number.Count / 2]);
            }

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
