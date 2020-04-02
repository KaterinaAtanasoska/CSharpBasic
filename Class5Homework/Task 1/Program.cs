using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;

            //Print the date that is 3 days from now
            DateTime days3FromNow = currentDateTime.AddDays(3);
            Console.WriteLine(days3FromNow);

            //Print the date that is one month from now
            DateTime monthFromNow = currentDateTime.AddMonths(1);
            Console.WriteLine(monthFromNow);

            //Print the date that is one month and 3 days from now
            DateTime daysAndMonth = currentDateTime.AddDays(3).AddMonths(1);
            Console.WriteLine(daysAndMonth);

            //Print 1 year and 2 months ago from today
            DateTime yearAndMonths = currentDateTime.AddMonths(-2).AddYears(-1);
            Console.WriteLine(yearAndMonths);

            //Print only the current month of today            
            Console.WriteLine(currentDateTime.Month);

            //Print only the current year of today
            Console.WriteLine(currentDateTime.Year);
        }
    }
}
