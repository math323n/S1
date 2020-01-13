using System;

namespace DateTimeOpgave03Delopgave02
{
    class Program
    {
        static void Main()  
        {
            DateTime currentYear = DateTime.Now;
            Console.WriteLine(currentYear.ToString("dd-mm-yyyy"));
            Console.WriteLine(currentYear.ToString("dd. mm yyyy"));
            Console.WriteLine(currentYear.ToString("dd. mm yyyy HH:mm:ss"));
            Console.WriteLine(currentYear.ToString("dd. dddd MMMM    yyyy"));
        }
    }
}
