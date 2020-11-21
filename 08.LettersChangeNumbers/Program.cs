using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double totalsum = 0;

            foreach (var item in input)
            {
                char letter1 = item[0];
                char letter2 = item[item.Length - 1];
                string number = String.Empty;
                foreach (var ch in item)
                {
                    if (Char.IsDigit(ch))
                    {
                        number += ch;
                    }
                }
                double n = double.Parse(number);

                if (Char.IsUpper(letter1))
                {
                    n /= (int)(letter1 - 64);
                }
                else
                {
                    n *= (int)(letter1 - 96);
                }

                if (Char.IsUpper(letter2))
                {
                    n -= (int)(letter2 - 64);
                }
                else
                {
                    n += (int)(letter2 - 96);
                }

                totalsum += n;
            }
            Console.WriteLine($"{totalsum:f2}");
        }
    }
}
