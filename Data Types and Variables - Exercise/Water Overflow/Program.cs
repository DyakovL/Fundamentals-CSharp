using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());

                sum+= litersToPour;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= litersToPour;
                }
                
            }

            Console.WriteLine(sum);


        }
    }
}
