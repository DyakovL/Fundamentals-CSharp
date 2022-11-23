using System;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int copy = n;
            int factorialSum = 0;

            while (copy > 0)
            {
                int lastDigid = copy % 10;
                copy /= 10;
                int factorial = 1;

                for (int i = 2; i <= lastDigid; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;
            }

            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
