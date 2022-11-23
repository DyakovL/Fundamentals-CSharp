using System;
using System.Linq;

namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            int vowelsCount = VowelsSum(text);

            Console.WriteLine(vowelsCount);
        }

        static int VowelsSum(string text)
        {

            int vowelsCount = 0;

            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };

            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount ++;
                }
            }

            return vowelsCount;
        }
    }
}
