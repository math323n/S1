using System;

namespace DateTimeOpgave02Delopgave01
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime utcNow = DateTime.UtcNow;

            Console.WriteLine(now.ToString());
            Console.WriteLine(today.ToString());
            Console.WriteLine(utcNow.ToString());
        }
    }
}
