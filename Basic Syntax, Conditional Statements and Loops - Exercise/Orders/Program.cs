using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double pricePerCapsule;
            int days;
            int capsuleCount;

            double finalPrice = 0;


            for (int i = 1; i <= orders; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsuleCount = int.Parse(Console.ReadLine());

                double pricePerOrder = (double)((days * capsuleCount) * pricePerCapsule);

                finalPrice += pricePerOrder;

                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:F2}");
            }

            Console.WriteLine($"Total: ${finalPrice:F2}");
        }
    }
}
