using System;
using System.Numerics;

namespace _05.MiltuplyBigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            item = (BigInteger.Parse(item) * n).ToString();

            Console.WriteLine(item);
        }
    }
}
