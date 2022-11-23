using System;
using System.Data.SqlTypes;

namespace PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            float money = float.Parse(Console.ReadLine());
            float students = float.Parse(Console.ReadLine());
            float lightSabers = float.Parse(Console.ReadLine());
            float robes = float.Parse(Console.ReadLine());
            float belts = float.Parse(Console.ReadLine());

            float extraLightSabers = (float)(Math.Ceiling(students * 1.1));
            //float freeBelts = (float)(Math.Round(students / 6));

            //float price = students * robes + (students - freeBelts) * belts + extraLightSabers * lightSabers;
            //float notEnough = price - money;

            float beltsNeeded = students;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    beltsNeeded--;
                }
            }

            float price = belts * beltsNeeded + students * robes + lightSabers * extraLightSabers;


            if (price <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv.");
            }
            else if (price > money)
            {
                Console.WriteLine($"John will need {(price - money):f2}lv more.");
            }
        }
    }
}