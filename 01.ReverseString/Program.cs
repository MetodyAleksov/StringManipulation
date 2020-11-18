using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string result1 = string.Empty;

                for (int i = input.Length - 1; i >= 0 ; i--)
                {
                    result1 += input[i];
                }
                result.Add(input, result1);

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
