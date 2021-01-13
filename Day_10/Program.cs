using System;
using System.Linq;

namespace Day_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CountBytes(n));
        }

        static int CountBytes(int n)
            => Convert.ToString(n, 2).Split('0').Max(x=>x.Length);
    }
}
