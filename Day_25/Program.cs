using System;
using System.Collections.Generic;

namespace Day_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for (int i = 0; i < len; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var elem in nums)
            {
                string result = IsPrime(elem) ? "Prime" : "Not prime";
                Console.WriteLine(result);
            }
        }

        static bool IsPrime(int num)
        {
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            if (num <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
