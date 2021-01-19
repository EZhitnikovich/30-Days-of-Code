using System;

namespace Day_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
