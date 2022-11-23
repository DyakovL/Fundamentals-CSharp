using System;

namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (input == "char") 
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                char result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (input == "string") 
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string result = GetMax(a, b);
                Console.WriteLine(result);
            }

        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        private static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        private static string GetMax(string a, string b)
        {
            //int sumA = 0;
            //int sumB = 0;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    sumA += a[i];
            //}

            //for (int i = 0; i < b.Length; i++)
            //{
            //    sumB += b[i];
            //}

            //if (sumA > sumB)
            //{
            //    return a;
            //}


            int result = a.CompareTo(b);

            if (result == 0)
            {
                return a;
            }

            return b;
        }
    }
}
