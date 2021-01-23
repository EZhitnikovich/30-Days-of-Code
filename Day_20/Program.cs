using System;
using System.Linq;

class Day_20
{

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, int.Parse);
        BubbleSort(out int swapCount, a);
        Console.WriteLine($"Array is sorted in {swapCount} swaps.\n" +
                          $"First Element: {a.First()}\n" +
                          $"Last Element: {a.Last()}");
    }

    static void BubbleSort(out int swapCount, int[] arr)
    {
        swapCount = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapCount++;
                }
            }
        }
    }
}