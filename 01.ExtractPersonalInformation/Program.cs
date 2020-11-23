using System;
using System.Collections.Generic;

namespace _01.ExtractPersonalInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> persons = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int startName = 0;
                int endName = 0;
                int startAge = 0;
                int endAge = 0;

                for (int k = 0; k < input.Length; k++)
                {
                    if (input[k] == '@')
                    {
                        startName = k;
                    }
                    if (input[k] == '|')
                    {
                        endName = k;
                    }
                    if (input[k] == '#')
                    {
                        startAge = k;
                    }
                    if (input[k] == '*')
                    {
                        endAge = k;
                    }
                }
                int lenghtName = endName - startName - 1;
                string name = input.Substring(startName + 1, lenghtName);
                int ageLenght = endAge - startAge - 1;
                string age = input.Substring(startAge + 1, ageLenght);
                persons.Add(name, age);
            }

            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Key} is {item.Value} years old.");
            }
        }
    }
}
