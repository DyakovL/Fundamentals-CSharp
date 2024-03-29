﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MOvingTasrget
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandInfo = command.Split();

                string commandType = commandInfo[0];
                int index = int.Parse(commandInfo[1]);
                int value = int.Parse(commandInfo[2]);

                if (commandType == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (commandType == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (commandType == "Strike")
                {
                    if (index - value >= 0 && index + value < targets.Count)
                    {
                        targets.RemoveRange(index - value, value * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

            }

            Console.WriteLine(String.Join("|", targets));

        }
    }
}
