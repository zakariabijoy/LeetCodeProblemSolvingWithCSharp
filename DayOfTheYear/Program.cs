using System;

namespace DayOfTheYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOfYear("2019-01-09"));
        }

        public static int DayOfYear(string date)
        {
           return DateTime.Parse(date).DayOfYear;
        }
    }
}
