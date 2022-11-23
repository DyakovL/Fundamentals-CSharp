using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < items.Length / 2; i++)
            {
                var oldElements = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = oldElements;

            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
