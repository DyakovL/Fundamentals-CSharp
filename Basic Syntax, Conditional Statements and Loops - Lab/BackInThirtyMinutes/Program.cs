﻿using System;

namespace BackInThirtyMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;

           
            if (minutes > 59)
            {
                hour++;
                minutes -= 60;
            }
            if (hour >= 23)
            {
                hour = 0;
            }
           
            
                Console.WriteLine($"{hour}:{minutes:D2}");
           
            


        }
    }
}
