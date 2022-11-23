using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main()
        {
            string food = Console.ReadLine();
            double nuts = 2.0;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;

            double coinCnt = 0;

            while (food != "Start")
            {
                
                double coins = Convert.ToDouble(food);

                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    coinCnt -= coins;
                    
                }

                coinCnt += coins;

                food = Console.ReadLine();
            }
            food = Console.ReadLine();
            while (food != "End")
            {
               
                switch (food)
                {
                    case "Nuts":
                        if ((coinCnt - nuts) >= 0)
                        {
                            Console.WriteLine($"Purchased {food}");
                            coinCnt -= nuts;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if ((coinCnt - water) >= 0)
                        {
                            Console.WriteLine($"Purchased {food}");
                            coinCnt -= water;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if ((coinCnt - crisps) >= 0)
                        {
                            Console.WriteLine($"Purchased {food.ToLower()}");
                            coinCnt -= crisps;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if ((coinCnt - soda) >= 0)
                        {
                            Console.WriteLine($"Purchased {food.ToLower()}");
                            coinCnt -= soda;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if ((coinCnt - coke) >= 0)
                        {
                            Console.WriteLine($"Purchased {food.ToLower()}");
                            coinCnt -= coke;
                        }
                        else 
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        break;
                }
                food = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coinCnt:F2}");
        }
    }
}
