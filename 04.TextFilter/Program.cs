using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] removedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var item in removedWords)
            {
                string censor = new string('*', item.Length);

                int index = text.IndexOf(item);
                while (index != -1)
                {
                    text = text.Replace(item, censor);

                    index = text.IndexOf(item);
                }
            }

            Console.WriteLine(text);
        }
    }
}
