using System;
using System.Globalization;

namespace TimeSpanOpgave02Delopgave02
{
    class Program
    {
        static void Main()
        {
            // Spørg om input fra brugeren
            Console.Write("Indtast dato i format dd/mm/yyyy hh:mm:ss ");
            
            // Parse input til DateTime
            DateTime userDate;
            if(DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss",
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None, out userDate))
            {
                // Print datoen
                Console.WriteLine(userDate);
            }
            else
            {
                // fejl behandling
                Console.WriteLine("Fejl, forkert input.");
                Main();
            }

            // spørg om brugerens anden input
            Console.Write("Indtast dato i format dd/mm/yyyy HH:mm:ss ");

            // parse det andet input til DateTime
            DateTime secondUserDate;
            if(DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss",
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None, out secondUserDate))
            {
                // Udskriv datoen
                Console.WriteLine(secondUserDate);
            }
            else
            {
                // behandl fejl
                Console.WriteLine("Fejl, forkert input.");
                Main();
            }
            
            // Udskriv hvor lang tid der er mellem de to datoer
            TimeSpan timeBetween = secondUserDate - userDate;
            Console.WriteLine("Tid mellem datoerne er: " + timeBetween);
        }
    }
}