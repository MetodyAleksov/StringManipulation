using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = String.Empty;
            foreach (char item in input)
            {
                var curr = (char)(item + 3);
                Console.Write(curr);
            }
        }
    }
}
