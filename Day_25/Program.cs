using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for(int i = 0; i< len; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            foreach(var elem in nums)
            {
                string result = IsPrime(elem) ? "Prime" : "Not prime";
                Console.WriteLine(result);
            }
        }

        static bool IsPrime(int num)
        {
            int countDivisors = Enumerable.Range(1, num).Where(x => num % x == 0).Count();
            return countDivisors == 2 ? true : false;
        }
    }
}
