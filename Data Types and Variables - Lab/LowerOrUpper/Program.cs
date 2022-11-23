using System;

namespace LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            bool result = false;
            result = char.IsUpper(letter);

            if (result == true )
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }


        }
    }
}
