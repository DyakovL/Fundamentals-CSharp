using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];
            //bool[] boolField = new bool[n];
            int[] initialIndexses = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach (int index in initialIndexses)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            string comamnd;

            while ((comamnd = Console.ReadLine()) != "end")
            {
                string[] cmdArrays = comamnd
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(cmdArrays[0]);
                string directions = cmdArrays[1];
                int flyLenght = int.Parse(cmdArrays[2]);

                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;
                if (directions == "left")
                {
                    flyLenght *= -1;
                }

                int nextIndex = ladybugIndex + flyLenght;

                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLenght;
                }

                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    continue;
                }

                field[nextIndex] = 1;
            }
                Console.WriteLine(String.Join(" ", field));
        }
    }
}
