using System;

namespace KontrolstrukturWhileLoopOpgave08
{
    class Program
    {
        static void Main()
        {
            // Opgave 08 - Kontrolstruktur while loop
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur while loop 08";
            /*-------------------------------------------*/

            bool programDone = false;

            while(!programDone)
            {
                // Tal generator. Generer to tilfældige tal fra 1 til 10
                Random rnd = new Random();
                int randomNumber1 = rnd.Next(1, 10);
                int randomNumber2 = rnd.Next(1, 10);
                int result = randomNumber1 + randomNumber2;

                // print spørgsmålet og tilfældige tal
                Console.Write("Indtast resultatet af de to tal: " + randomNumber1 +
                    " + " + randomNumber2 + ": ");

                // Få input som string
                string userInput = Console.ReadLine();

                // Luk programmet hvis man skriver Q
                if(userInput == "q")
                {
                    Environment.Exit(0);
                }

                // Se om input er en int
                if(int.TryParse(userInput, out int outputNumber))
                {
                    //Hvis svar er rigtigt
                    if(outputNumber == result)
                    {
                        Console.WriteLine("Tillykke, du har svaret rigtigt!");
                    }
                    // Ellers hvis forkert
                    else if(outputNumber != result)
                    {
                        Console.WriteLine("Desværre, det er ikke det rigtige svar. Prøv igen.");
                    }
                }
                // hvis man ikke skriver et tal
                else
                {
                    Console.WriteLine("Du må kun indtaste tal.");
                }
            }
        }
    }
}