using System;

namespace KontrolstrukturOpgave02Delopgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 03 Delopgave 02 - Kontrolstruktur 
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur 02";
            /*-------------------------------------------*/




            // Få brugerens alder
            Console.Write("Indtast din alder: ");
            string userInput = Console.ReadLine();
            
            if(userInput.Length >= 20)
            {
                Console.WriteLine("Wow dit navn er langt!");
                Console.WriteLine("Vi ses: " + userInput);
            }
            
        }
    }
}
