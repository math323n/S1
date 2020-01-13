using System;
using System.Linq;

namespace KontrolstrukturOpgave02Delopgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 02 Delopgave 03 - Kontrolstruktur 
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur 02";
            /*-------------------------------------------*/

           

            // Få brugerens tal
            Console.Write("Indtast et tilfældigt heltal fra -20 til 20: ");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int outputNumber);

            
            if (outputNumber > 20)
            {
                Console.WriteLine("dø");
            }
            else if(outputNumber >= 0)
            {
                Console.WriteLine("ok");
            }
            else if (outputNumber < -20)
            {
                Console.WriteLine("dø");
            }
            else if(outputNumber <= 0)
            {
                Console.WriteLine("nu ikke så negativ");
            }

        }
    }
}
