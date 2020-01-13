using System;
using System.Collections.Generic;
using System.Linq;

namespace KontrolstrukturWhileLoopOpgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 02 - Kontrolstruktur while loop
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur while loop 02";
            /*-------------------------------------------*/
            // Liste over tal der skal lægges sammen.

            List<int> integers = new List<int> {0,};

           // Hvor mange gange den skal loope
            int loopCount = 0;
            while(loopCount < 5) 
            {
                // Få brugerens input
                Console.Write("Indtast et tal: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int outputNumber);

                // Tilføj input til listen
                integers.Add(outputNumber);                   
                loopCount++;

            }
            //Udskriv det endelige resultat
            Console.WriteLine("-----------------------------");
            Console.WriteLine("           " + integers.Sum(x => Convert.ToInt32(x)));
            Console.WriteLine("-----------------------------");

        }
    }
}
