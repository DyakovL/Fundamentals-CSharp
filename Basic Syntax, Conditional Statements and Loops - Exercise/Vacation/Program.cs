using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = numOfPeople * 8.45;
                            break;
                        case "Saturday":
                            price = numOfPeople * 9.80;
                            break;
                        case "Sunday":
                            price = numOfPeople * 10.46;
                            break;
                    }
                    if (numOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Business":
                    //if (numOfPeople >= 100)
                    //{
                    //    numOfPeople -= 10;
                        
                    //}
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = numOfPeople * 10.90;
                            break;
                        case "Saturday":
                            price = numOfPeople * 15.60;
                            break;
                        case "Sunday":
                            price = numOfPeople * 16;
                            break;
                    }
                    if (numOfPeople >= 100)
                    {
                        numOfPeople -= 10;
                        price = numOfPeople * price;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = numOfPeople * 15;
                            break;
                        case "Saturday":
                            price = numOfPeople * 20;
                            break;
                        case "Sunday":
                            price = numOfPeople * 22.50;
                            break;
                    }
                    if (numOfPeople >= 10 && numOfPeople <= 20)
                    {
                        price *= 0.95;
                    }
                    break;
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
