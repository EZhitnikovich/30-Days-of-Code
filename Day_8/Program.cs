using System;
using System.Collections.Generic;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                var temp = Console.ReadLine().Split(' ');
                phoneBook.Add(temp[0], temp[1]);
            }

            for(int i = 0; i < phoneBook.Count; i++)
            {
                var name = Console.ReadLine();
                FindNumberByName(phoneBook, name);
            }
        }

        static void FindNumberByName(Dictionary<string, string> phoneBook, string name)
        {
            if(name == string.Empty)
            {
                return;
            }

            string result = string.Empty;
            if(phoneBook.TryGetValue(name, out string number))
            {
                result = $"{name}={number}";
            }
            else
            {
                result = "Not found";
            }

            Console.WriteLine(result);
        }
    }
}
