using System;

namespace SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Byte firstEmployee = Byte.Parse(Console.ReadLine());
            Byte secondEmployee = Byte.Parse(Console.ReadLine());
            Byte thirdEmployee = Byte.Parse(Console.ReadLine());
            Byte studentsCount = Byte.Parse(Console.ReadLine());

            int hour = firstEmployee + secondEmployee + thirdEmployee;

            //int timeNeeded = studentsCount
            double sum = 0;

            while (studentsCount > 0)
            {
                
                


                sum++;

                if (sum % 4 == 0)
                {
                    sum++;
                }

                studentsCount -= hour;
            }
            
            //int timeNeeded = hour / 60;

            Console.WriteLine(Math.Floor(sum));
        }
    }
}
