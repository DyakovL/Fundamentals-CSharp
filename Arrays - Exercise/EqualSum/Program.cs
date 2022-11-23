using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //create array

            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int sumOne = 0;
            int sumTwo = 0;

             for (int mid = 0; mid < nums.Length; mid++)
            {

                for (int i = mid + 1; i < nums.Length; i++)
                {
                    sumOne += nums[i];
                }

                for (int j = 0; j < mid; j++)
                {
                    sumTwo += nums[j];
                }

                if (sumOne == sumTwo)
                {
                    Console.WriteLine(mid);
                    return;
                }

                sumOne = 0;
                sumTwo = 0;
            }

            if (nums.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            Console.WriteLine("no");


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums.Length == 1)
            //    {
            //        Console.WriteLine(0);
            //        return;
            //    }

            //    int sumsOfI = Math.Abs(nums[i]);
            //    sumOne += sumsOfI;

            //    for (int j = nums.Length - 1; j >= 0; j--)
            //    {

            //        int index = nums[i] - i;
            //        int sumsOfJ = Math.Abs(nums[j]);
            //        sumTwo += sumsOfJ;


            //        if (sumOne != sumTwo)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine(String.Join(" ", (i + 1)));
            //            return;
            //        }

            //    }

            //    sumTwo = 0;

            //}

          
        }
    }
}
