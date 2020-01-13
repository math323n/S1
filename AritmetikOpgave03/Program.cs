using System;

namespace AritmetikOpgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 03 - Aritmetik
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Aritmetik 03";
            /*-------------------------------------------*/
            double firstNumber = 30 + 15;
            double secondNumber = 30 - 15;
            double thirdNumber = 30 * 15;
            double fourthNumber = 30 / 15;

            Console.WriteLine(
            "30 + 15 = " + firstNumber + "\n" +
            "30 - 15 = " + secondNumber + "\n" +
            "30 * 15 = " + thirdNumber + "\n" +
            "30 / 15 = " + fourthNumber);

        }
    }
}
