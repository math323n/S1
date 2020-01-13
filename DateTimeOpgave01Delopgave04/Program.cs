using System;

namespace DateTimeOpgave01Delopgave04
{
    class Program
    {
        static void Main()
        {
            DateTime currentTime = DateTime.Now;
            DateTime socialAct = new DateTime(2019, 11, 22);
            DateTime myArrive = new DateTime(2019, 12, 6, 8, 30, 20);
            DateTime news = new DateTime(2019, 11, 30);
            DateTime alsoCurrentTime = DateTime.Now;

            Console.WriteLine($"Nuværende tid: " + currentTime.ToString());
            Console.WriteLine(socialAct.ToString());
            Console.WriteLine($"Jeg ankom: " + myArrive.ToLongDateString());
            Console.WriteLine($"Nyhederne sidste lørdag: " + news.ToShortDateString());
            Console.WriteLine($"Også nuværende tid: " + alsoCurrentTime.ToString());
        }
    }
}
