using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace StudentAcaddemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {


                //string name = Console.ReadLine();    
                //double grade = double.Parse(Console.ReadLine());

                    if (!studentGrades.ContainsKey(name))
                    {
                        studentGrades[name] = grade;
                    }
                
                    studentGrades[name] += grade;

            }

            foreach (var student in studentGrades)
            {
                if ((student.Value / 2) >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {(student.Value / 2):f2}");
                }
                else if (student.Value <= 6.00 && student.Value >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value:f2}");
                }
            }
        }
    }
}
