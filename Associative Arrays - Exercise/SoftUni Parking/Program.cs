using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> register = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
                string username = cmdArgs[1];

                if (cmdType == "register")
                {
                    string licencePlateNumber = cmdArgs[2];

                    if (!register.ContainsKey(username))
                    {
                        register[username] = licencePlateNumber;
                        Console.WriteLine($"{username} registered {licencePlateNumber} successfully");
                    }
                    else
                    {
                        string registeredPleteNumber = register[username];
                        Console.WriteLine($"ERROR: already registered with plate number {licencePlateNumber}");
                    }
                }
                else if (cmdType == "unregister")
                {
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }


            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
