using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int biggestNum = int.MinValue;
            int mainNumber = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int maxSequence = 1;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        maxSequence++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (maxSequence > biggestNum)
                {
                    biggestNum = maxSequence;
                    mainNumber = i;
                }


            }

            for (int k = 0; k < biggestNum; k++)
            {
                Console.Write(nums[mainNumber] + " ");
            }

        }
    }
}
