﻿using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[nums.Length - 1];

            while (nums.Length != 1)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    //int[] condensed = new int[nums.Length];
                    condensed[i] = nums[i] + nums[i + 1];
                    if (i == nums.Length - 2)
                    {
                        nums = condensed;
                    }
                   
                }

                condensed = new int[nums.Length - 1];
                
            }
            Console.WriteLine(nums[0]);
            
        }
    }
}
