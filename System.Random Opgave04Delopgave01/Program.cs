using System;

namespace System.Random_Opgave04Delopgave01
{
    class Program
    {
        static void Main()
        {
            // Loop bool
            bool done = false;
            // Generator
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            while(!done)
            {
                Console.Write("Gæt hvilket tal er rigtigt fra 1 til 10: ");
                string userInput = Console.ReadLine();
                bool success = int.TryParse(userInput, out int userNumber);
                // Hvis tallet kan parse
                if(success)
                {
                    if(userNumber == randomNumber)
                    {
                        Console.WriteLine("Du gættede rigtigt. Tallet var: " + randomNumber);
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("Tallet var ikke rigtigt, prøv igen.");
                    }
                }
                // Ellers hvis ikke kan parse
                else
                {
                    // printer dette og looper tilbage, så brugeren kan prøve igen.
                    Console.WriteLine("Du indtastede ikke et tal, prøv igen.");
                }
            }
        }
    }
}