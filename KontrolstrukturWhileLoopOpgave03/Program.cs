using System;

namespace KontrolstrukturWhileLoopOpgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 03 - Kontrolstruktur while loop
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur while loop 03";
            /*-------------------------------------------*/
            // Input
            Console.Write("Indtast noget tekst: ");
            string userInput = Console.ReadLine();
            
            // Char array
            var text = userInput.ToCharArray();
            var textLines = string.Join("\n", text);

            // Print
            Console.WriteLine(textLines);
        }
    }
}
