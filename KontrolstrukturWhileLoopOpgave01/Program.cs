using System;

namespace KontrolstrukturWhileLoopOpgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 01 - Kontrolstruktur while loop
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur while loop 01";
            /*-------------------------------------------*/
           
            // hvor mange gange programmet skal loope
            int loopCount = 0;

            // Loop 10 gange
            while (loopCount < 10)
            {
                loopCount++;
                // Print dette
                Console.Write("While statement ");
                Console.WriteLine(loopCount);
                
                // Hvis når til 10, stop løkken og eksekver dette kode
                if (loopCount == 10)
                {
                    Console.WriteLine("Denne løkke har kørt 10 gange.");
                }
            }
        }
    }
}
