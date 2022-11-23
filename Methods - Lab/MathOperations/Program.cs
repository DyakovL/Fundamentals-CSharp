using System;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char input = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = MathOperations(num, input, num2);

            Console.WriteLine(result);
        }

        static int MathOperations(int num, char input, int num2)
        {
            int result = 0;

            if (input == '*')
            {
                result = num * num2;
            }
            else if (input == '/')
            {
                result = num / num2;
            }
            else if (input == '+')
            {
                result = num + num2;
            }
            else if (input == '-')
            {
                if (num > num2)
                {
                    result = num - num2;
                }
                else
                {
                    result = num2 - num;
                }
            }

            return result;
        }
    }
}
