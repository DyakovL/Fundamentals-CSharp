using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matchNames = Regex.Matches(names, regex);

            foreach (Match matches in matchNames)
            {
                Console.Write(matches.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
