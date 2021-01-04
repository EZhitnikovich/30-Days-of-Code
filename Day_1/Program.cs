using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int inputI = int.Parse(Console.ReadLine());
            double inputD = double.Parse(Console.ReadLine());
            string inputS = Console.ReadLine();

            Console.WriteLine($"{i+inputI}\n" +
                              $"{d+inputD}\n" +
                              $"{s+inputS}");
        }
    }
}
