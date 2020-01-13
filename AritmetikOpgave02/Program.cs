using System;

namespace AritmetikOpgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 02 - Aritmetik
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Aritmetik 02";
            /*-------------------------------------------*/
            int numCalc = 50 + 30 - 5;
            string result = "Resultatet af 50 + 30 - 5 er ";


            Console.WriteLine(result + numCalc);
            Console.ReadLine();
        }
    }
}
