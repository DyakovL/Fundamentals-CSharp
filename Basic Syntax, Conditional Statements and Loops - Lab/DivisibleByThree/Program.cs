﻿using System;

namespace DivisibleByThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }





        }
    }
}
