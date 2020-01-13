using System;

namespace AritmetikOpgave06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 06 - Aritmetik
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(90, 30);
            Console.Title = "Aritmetik 06";
            /*-------------------------------------------*/


            Console.Write("Indtast antallet af sekunder, som skal omregnes til minutter og sekundter: ");

            int totalSeconds = Convert.ToInt32(Console.ReadLine());

            int mins = totalSeconds / 60;
            int secs = totalSeconds % 60;

            Console.WriteLine($"{totalSeconds} sekunder svarer til {mins} minutter og {secs} sekunder");
        }
    }
}
