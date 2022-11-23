using System;

namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Repeat(word, n);

        }

        private static void Repeat(string word, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(word);
            }
        }
    }
}
