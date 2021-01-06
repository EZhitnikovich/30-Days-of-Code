using System;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(WeirdOrNotWeird(n));
        }

        static string WeirdOrNotWeird(int n)
        {
            string result = string.Empty;

            if (n % 2 == 1)
            {
                result = "Weird";
            }
            else
            {
                if (n >= 2 && n <= 5)
                {
                    result = "Not Weird";
                }
                else if (n>=6 && n <= 20)
                {
                    result = "Weird";
                }
                else if (n > 20)
                {
                    result = "Not Weird";
                }
            }

            return result;
        }
    }
}
