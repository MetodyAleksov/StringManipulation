using System;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] arr = text.ToCharArray();

            string nums = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsDigit(arr[i]))
                {
                    nums += arr[i];
                }
                else if (Char.IsLetter(arr[i]))
                {
                    letters += arr[i];
                }
                else
                {
                    other += arr[i];
                }
            }

            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
