using System;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Round(GetTotalCost(mealCost, tipPercent, taxPercent)));
        }

        static double GetTotalCost(double cost, int tipPercent, int taxPercet)
        {
            double tip = tipPercent / 100d * cost;
            double tax = taxPercet / 100d * cost;

            return cost + tip + tax;
        }
    }
}
