using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string biggestName = string.Empty;
            double biggest = double.MinValue;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float output = (float)(Math.PI * Math.Pow(radius, 2) * height);

                if (output >= biggest)
                {
                    biggestName = name;
                    biggest = output;
                }
            }

            Console.WriteLine(biggestName);
        }
    }
}
