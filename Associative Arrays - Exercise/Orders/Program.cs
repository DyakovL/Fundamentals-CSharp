using System;
using System.Collections.Generic;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string product = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                int qty = int.Parse(cmdArgs[2]);

                if (products.ContainsKey(product))
                {
                    products[product][1] += qty;
                    products[product][0] = price;
                }
                else
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(qty);
                }

                
            }

            


            foreach (var purchase in products)
            {
                Console.WriteLine($"{purchase.Key} -> {(purchase.Value[0] * purchase.Value[1]):f2}");
            }
        }
    }
}
