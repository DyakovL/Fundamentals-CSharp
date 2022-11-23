using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());
            int timesToRotate = numberOfRotations % array.Length;
            for (int j = 1; j <= timesToRotate; j++)
            {

            
            int firstEll = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];
                }
            array[array.Length - 1] = firstEll;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
