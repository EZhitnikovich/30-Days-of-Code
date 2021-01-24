using System;
using System.Collections.Generic;

class Printer
{

	public static void PrintArray<T>(IEnumerable<T> arr)
	{
		Console.WriteLine(string.Join("\n", arr));
	}


	static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] intArray = new int[n];
		for (int i = 0; i < n; i++)
		{
			intArray[i] = Convert.ToInt32(Console.ReadLine());
		}

		n = Convert.ToInt32(Console.ReadLine());
		string[] stringArray = new string[n];
		for (int i = 0; i < n; i++)
		{
			stringArray[i] = Console.ReadLine();
		}

		PrintArray<int>(intArray);
		PrintArray<string>(stringArray);
	}
}