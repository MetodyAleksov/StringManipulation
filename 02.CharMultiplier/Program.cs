using System;

namespace _02.CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[] arr1 = input[0].ToCharArray();
            char[] arr2 = input[0].ToCharArray();

            int result = CharMultiplier(arr1, arr2);

            Console.WriteLine(result);
        }

        static int CharMultiplier(char[] arr1, char[] arr2)
        {
            int result = 0;

            int longestChar = 0;

            if (arr1.Length >= arr2.Length)
            {
                longestChar = arr1.Length;
            }
            else
            {
                longestChar = arr2.Length;
            }

            for (int i = 0; i < longestChar; i++)
            {
                if (arr1.Length <= i || arr2.Length <= i)
                {
                    if (arr1.Length <= i)
                    {
                        result += arr2[i];
                    }
                    if (arr2.Length <= i)
                    {
                        result += arr1[i];
                    }
                }
                else
                {
                    result += (arr1[i] * arr2[i]);
                }
            }

            return result;
        }
    }
}
