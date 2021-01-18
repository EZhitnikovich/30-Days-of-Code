using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] arr)
    {
        elements = arr;
    }

    public void ComputeDifference()
    {
        maximumDifference = elements.Max() - elements.Min();
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.ComputeDifference();

        Console.Write(d.maximumDifference);
    }
}