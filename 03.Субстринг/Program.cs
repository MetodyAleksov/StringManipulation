using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().ToLower();
            string words = Console.ReadLine().ToLower();

            int index = words.IndexOf(key);

            while (index != -1)
            {
                words = words.Remove(index, key.Length);
                index = words.IndexOf(key);
            }

            Console.WriteLine(words);
        }
    }
}
