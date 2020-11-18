using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result += item;
                }
            }
            Console.WriteLine(result);
        }
    }
}
