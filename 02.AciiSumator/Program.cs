using System;

namespace _02.AciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            int n1 = (int)number1[0];
            string number2 = Console.ReadLine();
            int n2 = (int)number2[0];
            int longerNum = 0;
            int shorterNum = 0;
            if (n1 >= n2)
            {
                longerNum = n1;
                shorterNum = n2;
            }
            else
            {
                longerNum = n2;
                shorterNum = n1;
            }
            int sum = 0;

            string input = Console.ReadLine();

            foreach (var item in input)
            {
                if (item < longerNum && item > shorterNum)
                {
                    sum += (int)item;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
