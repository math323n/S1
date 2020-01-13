using System;

namespace KontrolstrukturSwitchOpgave04
{
    class Program
    {
        enum Importance
        {
           None,
           Trivial,
           Regular,
           Important,
           Critical
        }



        static void Main(string[] args)
        {
            // Opgave 04 - Kontrolstruktur switch
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur switch 04";
            /*-------------------------------------------*/
            
            Console.Write("Beskriv vitigheden af en opstået fejl\nNone\nTrivial\n" +
                "Regular\nImportant\nCritical\nEller bare fra 0 til 4: ");
            string userInput = Console.ReadLine();
            Enum.TryParse(userInput, true, out Importance importance);
            switch(importance)
            {
                case Importance.None:
                    Console.WriteLine("Det lyder ligegyldigt.");
                    break;
                case Importance.Trivial:
                    Console.WriteLine("Det sætter jeg praktikanten til at ordne.");
                    break;
                case Importance.Regular:
                    Console.WriteLine("Mon ikke det nok går...");
                    break;
                case Importance.Important:
                    Console.WriteLine("Jeg drikker lige en kop kaffe, så er jeg der.");
                    break;
                case Importance.Critical:
                    Console.WriteLine("Red jer selv. . .");
                    break;
                default:
                    Console.WriteLine("Ukendt");
                    break;
            }
           

        }
    }
}
