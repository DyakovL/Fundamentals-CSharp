using System;
using System.Linq;

namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] one = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] two = Console.ReadLine()
                .Split(' ')
                .ToArray();


            for (int i = 0; i < two.Length; i++)
            {
                for (int j = 0; j < one.Length; j++)
                {
                    if (two[i] != one[j])
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(two[i] + " ");
                    }
                }
            }
        }
    }
}
