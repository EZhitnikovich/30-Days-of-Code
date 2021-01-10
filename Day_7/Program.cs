using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Day_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))[0..len];
            Console.WriteLine(string.Join(" ", ReverseArray(arr)));
        }

        static IEnumerable<T> ReverseArray<T>(IEnumerable<T> arr)
            => arr.Reverse();
    }
}
