using System;
using System.Threading;

namespace KontrolstrukturWhileLoopOpgave06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 06 - Kontrolstruktur while loop
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur while loop 06";
            /*-------------------------------------------*/
            bool programDone = false;
            while(!programDone)
            {
                Console.Clear();
                Console.WriteLine("Skriv 1 for at høre om køer.\n" +
                    "Skriv 2 for at få resultatet af 2*4\n" +
                    "Skriv 3 for at afslutte programmet.");

                // input
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int outputNumber);

                // Hvis input er 1
                if(outputNumber == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Køer elsker du på din tallerken.");
                    Thread.Sleep(3000);
                }
                // Hvis input er 2
                else if(outputNumber == 2)
                {
                    Console.Clear();
                    Console.WriteLine(2 * 4);
                    Thread.Sleep(3000);
                }
                // Til at lukke programmet hvis input er 3
                else if(outputNumber == 3)
                {
                    // Lukker loopet, 
                    break;
                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine("Loopet er brudt.");
        }
    }
}
