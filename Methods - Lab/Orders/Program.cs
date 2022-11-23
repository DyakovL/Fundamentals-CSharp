using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                double price = 1.50;
                FinalPrice(price, qty);
            }
            else if (product == "water")
            {
                double price = 1.00;
                FinalPrice(price, qty);
            }
            else if (product == "coke")
            {
                double price = 1.40;
                FinalPrice(price, qty);
            }
            else if (product == "snacks")
            {
                double price = 2.00;
                FinalPrice(price, qty);
            }
            
        }

        private static void FinalPrice (double price, int qty)   
        {
            double finalPrice = price * qty;
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
