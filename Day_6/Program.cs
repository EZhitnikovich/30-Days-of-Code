using System;
using System.Linq;

namespace Day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string even = GetEvenLetters(word);
                string odd = GetOddLetters(word);
                Console.WriteLine($"{even} {odd}");
            }
        }

        static string GetEvenLetters(string word)
        {
            string result = string.Empty;

            for(int i = 0; i < word.Length; i += 2)
            {
                result += Convert.ToString(word[i]);
            }

            return result;
        }

        static string GetOddLetters(string word)
        {
            string result = string.Empty;

            for (int i = 1; i < word.Length; i += 2)
            {
                result += Convert.ToString(word[i]);
            }

            return result;
        }
    }
}
