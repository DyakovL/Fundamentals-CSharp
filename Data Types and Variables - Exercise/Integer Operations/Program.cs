using System;

namespace Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int forth = int.Parse(Console.ReadLine());

            int first = one + two;
            double second = (double)(first / three);
            int third = (int)(second * forth);

            Console.WriteLine(third);



        }
    }
}
