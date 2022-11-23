using System;

namespace GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal foodInKg = decimal.Parse(Console.ReadLine());
            decimal hayInKg = decimal.Parse(Console.ReadLine());
            decimal coverInKg = decimal.Parse(Console.ReadLine());
            decimal guineaPigWeightInKg = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                foodInKg -= 0.3m;
                if (i % 2 == 0)
                {
                    hayInKg -= foodInKg * 0.05m;
                }

                if (i % 3 == 0)
                {
                    coverInKg -= guineaPigWeightInKg / 3;
                }

                if (foodInKg <= 0 || hayInKg <= 0 || coverInKg <= 0)
                {
                    break;
                }
            }

            if (foodInKg <= 0 || hayInKg <= 0 || coverInKg <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInKg:f2}, Hay: {hayInKg:f2}, Cover: {coverInKg:f2}.");
            }

        }
    }
}
