using System;

namespace SammenligningsoperatorerOpgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 03 - Sammenligningsoperatorer 
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Sammenligningsoperatorer 03";
            /*-------------------------------------------*/

            //Programmet antager man har haft fødselsdag
            // Done = false
            bool done = false;

            // While loop
            while(!done)
            {
                // Få det nuværende år
                int currentYear = DateTime.Now.Year;

                // Få brugerens fødselsår
                Console.Write("Indtast dit fødselsår: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int outputAge);

                // Træk brugerens alder fra currentYear, til at få den aktuelle alder.
                outputAge = currentYear - outputAge;
                // print brugerens alder
                Console.WriteLine("Du er " + outputAge + " år gammel");

                // If 
                if(outputAge >= 18)
                {
                    Console.WriteLine("Du må købe spiritus, og øl");
                }
                //Else if
                else if (outputAge >= 16)
                {
                    Console.WriteLine("Du må købe øl.");
                }
                else
                {
                    Console.WriteLine("Du er ikke gammel nok til alkohol.");
                }

            }
        }
    }
}
