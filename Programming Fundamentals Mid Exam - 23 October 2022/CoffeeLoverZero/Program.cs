using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace CoffeeLoverZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine()
                .Split(' ')
                .ToList();

            int n = int.Parse(Console.ReadLine());

            int count = 0;

            

            while (count < n)
            {
                string command = Console.ReadLine();
                string[] commandParams = command.Split();
                count++;

                string cmdType = commandParams[0];

                

                if (cmdType == "Include")
                {
                    string newCoffee = commandParams[1];
                    coffees.Add(newCoffee);
                }
                else if (cmdType == "Remove")
                {
                    int cmdNum = (int)int.Parse(commandParams[2]);
                    if(cmdNum >= coffees.Count)
                    {
                        continue;
                    }

                    int coffee = cmdNum;
                        
                    if (commandParams[1] == "first")
                    {
                        for (int i = 0; i < coffee; i++)
                        {

                            coffees.Remove(coffees[0]);
                            
                        }
                        continue;
                    }
                    else if (commandParams[1] == "last")
                    {
                        coffees.Reverse();
                        for (int i = 0; i < coffee; i++)
                        {
                            
                            coffees.Remove(coffees[0]);
                            
                        }
                    }
                    coffees.Reverse();
                    
                }
                else if (cmdType == "Prefer")
                {

                    int idexOne = int.Parse(commandParams[1]);
                    int idexTwo = int.Parse(commandParams[2]);

                    bool idexOneTrue = false;
                    bool idextwoTrue = false;

                    for (int i = 0; i < coffees.Count; i++)
                    {
                        int nums = i;
                        if (nums == idexOne)
                        {
                            idexOneTrue = true;
                            
                        }
                        else if (nums == idexTwo)
                        {
                            idextwoTrue = true;
                        }

                        
                    }
                    if (idexOneTrue == true && idextwoTrue == true)
                    {
                        string newCoffee = coffees[idexOne];
                        coffees[idexOne] = coffees[idexTwo];
                        coffees[idexTwo] = newCoffee;
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                else if (cmdType == "Reverse")
                {
                    coffees.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(String.Join(" ", coffees));
        }

       
            
        
    }
}
