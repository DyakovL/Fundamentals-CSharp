using System;
using System.Collections.Generic;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();


            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }
                
                    courseInfo[courseName].Add(studentName);
                

            }

            foreach (var kvp in courseInfo)
            {
                //string courseName = kvp.Key;
                //List<string> students = kvp.Value;

                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (string studentName in kvp.Value)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
