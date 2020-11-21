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
            char[] arr2 = input[1].ToCharArray();

            int index = 0;

            if (arr1.Length >= arr2.Length)
            {
                index = arr1.Length;
            }
            else
            {
                index = arr2.Length;
            }

            int sum = 0;
            for (int i = 0; i < index; i++)
            {
                if (i >= arr1.Length || i >= arr2.Length)
                {
                    if (i >= arr1.Length)
                    {
                        sum += (int)arr2[i];
                    }
                    if (i >= arr2.Length)
                    {
                        sum += (int)arr1[i];
                    }
                }
                else
                {
                    sum += (int)arr1[i] * (int)arr2[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
