using System;

namespace KontrolstrukturOpgave04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 03 - Kontrolstruktur 
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur 03";
            /*-------------------------------------------*/

            
            bool done = false;
            while(!done)
            {
                int letterPrice = 0;
                Console.WriteLine("Indtast vægten på dit brev");
                string firstUserInput = Console.ReadLine();
                double.TryParse(firstUserInput, out double letterWeight);
                Console.WriteLine("Skal brevet sendes express?\ny/n");
                string secondUserInput = Console.ReadLine();
                if(secondUserInput == "y")
                {
                    letterPrice += 5;
                }
                if(letterWeight >= 250)
                {
                    letterPrice += 30;
                }
                else if(letterWeight >= 100)
                {
                    letterPrice += 15;
                }
                else if(letterWeight >= 50)
                {
                    letterPrice += 12;
                }
                else if(letterWeight >= 20)
                {
                    letterPrice += 7;
                }
                else if(letterWeight >= 0)
                {
                    letterPrice += 5;
                }
                Console.WriteLine($"Prisen er:  {letterPrice:C}");
            }


        }
    }
}
