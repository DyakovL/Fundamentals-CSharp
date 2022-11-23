using System;
using System.Xml.Schema;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                char chare = userName[i];
                password += chare;
            }

            int totalTries = 0;
            string truePassword;
            while ((truePassword = Console.ReadLine()) != password)
            {
                totalTries++;

                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }

            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
