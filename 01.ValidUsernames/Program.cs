using System;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in usernames)
            {
                bool noOther = true;

                foreach (char curr in item.ToCharArray())
                {
                    if (!((Char.IsLetter(curr) || Char.IsDigit(curr) || curr == '-' || curr == '_') && (item.Length >= 3 && item.Length <= 16)))
                    {
                        noOther = false;
                    }
                }

                if (noOther)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
