using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginning = int .Parse(Console.ReadLine());
            int end = int .Parse(Console.ReadLine());

            for (int i = beginning; i <= end; i++)
            {
                char currCh = (char)i;
                Console.Write(currCh + " ");
            }



        }
    }
}
