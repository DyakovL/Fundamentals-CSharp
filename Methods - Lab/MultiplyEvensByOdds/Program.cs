using System;

namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int absValue = Math.Abs(int.Parse(input));

            int sumOfEvenNumbers = SumOfEvenNumbers(absValue.ToString());
            int sumOfOddNumbers = SumOfOddNumbers(absValue.ToString());


            int result = sumOfEvenNumbers * sumOfOddNumbers;
            Console.WriteLine(result);
        }

        private static int SumOfEvenNumbers(string input) 
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currNum = int.Parse(input[i].ToString());

                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }

            }

            return sum;
        }

        private static int SumOfOddNumbers(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currNum = int.Parse(input[i].ToString());

                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }

            }

            return sum;
        }
    }
}
