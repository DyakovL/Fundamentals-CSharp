using System;
using System.Linq;

namespace _1._Encrypt__Sort__and_Print_Array
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];
            int[] currNumName = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                /*string[]*/ names = Console.ReadLine()
                    .Split('\n', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var name in names)
                {
                    foreach (var letter in name)
                    {
                        char churrCh = letter;
                        
                        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
                            letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                        {
                            sum += churrCh * name.Length;
                        }
                        else
                        {
                            sum += churrCh / name.Length;
                        }

                    }
                        currNumName[i] = sum;
                        sum = 0;
                }

            }

            Array.Sort(currNumName);

            foreach (var name in currNumName)
            {
                Console.WriteLine(string.Join(' ', name));
            }

        }
    }
}
