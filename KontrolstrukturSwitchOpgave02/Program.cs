using System;

namespace KontrolstrukturSwitchOpgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 02 - Kontrolstruktur switch
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur switch 02";
            /*-------------------------------------------*/




            // Få input
            Console.Write("Indtast et familiemedlen (fx mor, bedstefar eller lignende): ");
            string input = Console.ReadLine();

            // Switch
            switch(input.ToLower())
            {
                // Case 1
                case "mor":
                case "far":
                    Console.WriteLine("Du har indtastet et " + "2. generationsmedlem af familien.");
                    break;
                // Case 2
                case "bedstefar":
                case "bedstemor":
                case "farfar":
                case "mormor":
                case "farmor":
                    Console.WriteLine("Du har indtastet et " + "3. generationsmedlem af familien.");
                    break;
                // Default
                default:
                    Console.WriteLine("Du har indtastet et ukendt familiemedlem");
                    break;
            }
        }
    }
}
