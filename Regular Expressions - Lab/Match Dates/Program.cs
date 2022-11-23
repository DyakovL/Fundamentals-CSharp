using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection) 
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;


                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }


        }
    }
}
