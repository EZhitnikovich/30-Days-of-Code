using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            for(int i = 0; i < 6; i++)
            {
                arr.Add(InputIntList());
            }

            Console.WriteLine(GetMaxHourglassSum(arr));
        }

        static int GetMaxHourglassSum(List<List<int>> arr)
        {
            int maxSum = int.MinValue;
            for(int i = 0; i<arr.Count() - 2; i++)
            {
                for(int j = 0; j<arr.First().Count() - 2; j++)
                {
                    int sum = (arr[i][j]+arr[i][j+1]+ arr[i][j+2])+
                                         arr[i+1][j+1]+
                               (arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2]);

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            return maxSum;
        }

        static List<int> InputIntList()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
    }
}
