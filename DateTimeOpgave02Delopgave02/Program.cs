using System;

namespace DateTimeOpgave02Delopgave02
{
    class Program
    {
        static void Main()
        {
            // current time
            DateTime timeNow = DateTime.Now;
            // add 1 year
            DateTime addOneYear = timeNow.AddYears(1);
            Console.WriteLine(addOneYear.ToString());

            // Subtract two years
            DateTime subtractTwoYears = timeNow.AddYears(-2);
            Console.WriteLine(subtractTwoYears.ToString());

            // Add 30 days
            DateTime addThirtyDays = timeNow.AddDays(30);
            Console.WriteLine(addThirtyDays.ToString());

            // Subtract 17 days
            DateTime subtractThirtyDays = timeNow.AddDays(-17);
            Console.WriteLine(subtractThirtyDays.ToString());

            // Add 3 months
            DateTime addThreeMonths = timeNow.AddMonths(3);
            Console.WriteLine(addThreeMonths.ToString());

            // Add 23 hours
            DateTime add23Hours = timeNow.AddHours(23);
            Console.WriteLine(add23Hours.ToString());

            // Subtract 11 hours
            DateTime subtract11Hours = timeNow.AddHours(-11);
            Console.WriteLine(subtract11Hours.ToString());
            
            // Add both 23 hours and 17 minutes to current realtime
            TimeSpan addedBothHourAndMinute = new TimeSpan(23, 17, 0);
            DateTime timeBoth = DateTime.Now.Add(addedBothHourAndMinute);
            Console.WriteLine(timeBoth);

        }

    }
}