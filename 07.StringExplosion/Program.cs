using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            int power = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var vurrChar = arr[i];
                if (vurrChar == '>')
                {
                    power += int.Parse(arr[i + 1].ToString());
                    continue;
                }
                if (power > 0)
                {
                    arr = arr.Remove(i, 1);
                    i--;
                    power--;
                }
            }

            Console.WriteLine(arr);
        }
    }
}
