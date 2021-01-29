using System;

namespace Day_26
{
    class Program
    {
        static void Main(string[] args)
        {
            var returned = InputIntArray();
            var due = InputIntArray();

            var returnedDate = ConvertToDate(returned);
            var dueDate = ConvertToDate(due);

            int result = CalculateFine(returnedDate, dueDate);
            Console.WriteLine(result);
        }

        public static int CalculateFine(DateTime returnDate, DateTime dueDate)
        {
            int fine = 0;

            if(returnDate< dueDate)
            {
                return 0;
            }

            if(returnDate.Year > dueDate.Year)
            {
                fine = 10000;
            }
            else if(returnDate.Month > dueDate.Month)
            {
                fine = 500 * (returnDate.Month - dueDate.Month);
            }
            else if(returnDate.Day > dueDate.Month)
            {
                fine = 15 * (returnDate.Day - dueDate.Day);
            }

            return fine;
        }

        private static DateTime ConvertToDate(int[] arr)
        {
            if(arr.Length != 3)
            {
                throw new Exception("Length must be 3");
            }

            return new DateTime(arr[2], arr[1], arr[0]);
        }

        private static int[] InputIntArray()
            => Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    }
}
