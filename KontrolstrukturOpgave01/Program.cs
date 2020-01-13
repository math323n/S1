using System;

namespace KontrolstrukturOpgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 01 - Kontrolstruktur 
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur 01";
            /*-------------------------------------------*/
            bool done = false;

            while(!done)
            {
                Console.Write("Indtast et tal mellem 1 og 20: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int outputNumber);
                
                if(outputNumber == 10)
                {
                    Console.WriteLine("Tallet er 10");
                    done = true;
                }
                else if (outputNumber > 10)
                {
                    Console.WriteLine("Tallet er større end 10.");
                }
                else if (outputNumber < 10)
                {
                    Console.WriteLine("Tallet er ikke 10");
                }
                else
                {
                    Console.WriteLine("forkert");
                }
            }
            
        }
    }
}
