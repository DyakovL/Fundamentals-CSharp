using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace CompanyUsers
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companyWorkers= new Dictionary<string, List<string>>();


            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = args[0];
                string id = args[1];

                

                if (!companyWorkers.ContainsKey(company))
                {
                    companyWorkers[company] = new List<string>();
                    companyWorkers[company].Add(id);
                }

                if (!companyWorkers[company].Contains(id))
                {
                    companyWorkers[company].Add(id);
                }
               

                
            }

            foreach (var kvp in companyWorkers)
            {
                Console.WriteLine(kvp.Key);

                foreach (var worker in kvp.Value)
                {
                    Console.WriteLine($"-- {worker}");
                }
            }
        }
    }
}
