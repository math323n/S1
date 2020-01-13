using System;

namespace TimeSpanOpgave01Delopgave01
{
    class Program
    {
        static void Main()
        {
            TimeSpan spanTwoDays = new TimeSpan(2, 4, 30, 11);
            TimeSpan aspitTime = new TimeSpan(6, 0, 0);
            TimeSpan wokeUp = new TimeSpan(1, 30, 20);
            Console.WriteLine(spanTwoDays.ToString());
            Console.WriteLine(aspitTime.ToString());
            Console.WriteLine(wokeUp.ToString());
            string firstTime = "00:39:02";
            
            TimeSpan a = TimeSpan.Parse(firstTime);
            TimeSpan EighteenDays = TimeSpan.Parse("18:00:00:00");
            TimeSpan c = TimeSpan.Parse("28:07:16:2");
            Console.WriteLine(a.ToString());
            Console.WriteLine(EighteenDays.ToString());
            Console.WriteLine(c.ToString());
            
            




        }
    }
}
