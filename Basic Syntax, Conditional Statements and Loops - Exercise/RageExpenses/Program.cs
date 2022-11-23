using System;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());


            int headsets = 0;
            int mouses = 0;
            int keyboards = 0;
            int displays = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsets++;
                    
                }

                if (i % 3 == 0)
                {
                    mouses++;
                    
                }

                if (i % 6 == 0)
                {
                    keyboards++;
                    
                }

                if (i % 12 == 0)
                {
                    displays++;
                    
                }
            }

            float finalPrice = headsetPrice * headsets + mousePrice * mouses + keyboardPrice * keyboards + displayPrice * displays;

            Console.WriteLine($"Rage expenses: {finalPrice:F2} lv.");
        }
    }
}
