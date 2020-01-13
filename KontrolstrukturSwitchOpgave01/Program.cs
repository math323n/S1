using System;

namespace KontrolstrukturSwitchOpgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 01 - Kontrolstruktur switch
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur switch 01";
            /*-------------------------------------------*/

            Console.WriteLine("Indtast et af de følgende dyr:\n1. gris\n2. hund\n3. kat\n4. ko");
            string userInput = Console.ReadLine();
            switch(userInput.ToLower())
            {
                case ("gris"):
                    Console.WriteLine("Grisen har en grisehale og leverer bacon");
                    break;
                case ("hund"):
                    Console.WriteLine("Hunde er aliens");
                    break;
                case ("kat"):
                    Console.WriteLine("katte er katte");
                    break;
                case ("ko"):
                    Console.WriteLine("Du elsker dem på din tallerken");
                    break;
                default:
                    Console.WriteLine("Fejl, ukendt dyr");
                    break;
            }
        }
    }
}
