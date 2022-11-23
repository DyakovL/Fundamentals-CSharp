 using System;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string file = input[input.Length - 1];

            string[] splitLastword = file.Split('.');

            string fileName = splitLastword[0];
        }
    }
}
