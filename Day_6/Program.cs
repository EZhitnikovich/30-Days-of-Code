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
            => string.Join("", Enumerable.Range(0, word.Length).Where(x => x % 2 == 0).Select(x => word[x]));

        static string GetOddLetters(string word)
            => string.Join("", Enumerable.Range(1, word.Length-1).Where(x => x % 2 != 0).Select(x => word[x]));
    }
}
