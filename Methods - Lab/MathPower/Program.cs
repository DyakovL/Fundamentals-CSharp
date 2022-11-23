using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            NumberToThePowerOfN(num,n);
        }

        private static void NumberToThePowerOfN(double num, double n)
        {
            double result = 1;
            for (int i = 0; i < n; i++)
            {
                result*= num;
            }

            Console.WriteLine(result);
        }
    }
}
