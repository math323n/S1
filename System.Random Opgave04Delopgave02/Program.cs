using System;

namespace System.Random_Opgave04Delopgave01
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            // Loop bool
            bool done = false;
            bool arrayLimitDone = false;
            
            // Array til grænser af interval
            while(!arrayLimitDone)
            {
                Console.Write("Hvilket grænser til intervallet ønsker du?\nFra 0 til 10, med mellemrum: ");
                string[] interval = Console.ReadLine().Split(' ');
                int firstIntervalLimit = int.Parse(interval[0]);
                int secondIntervalLimit = int.Parse(interval[1]);
                
                if(firstIntervalLimit > -1 && secondIntervalLimit < 11)
                {
                    
                    arrayLimitDone = true;
                }
                else
                {
                    Console.WriteLine("Du indtastede forkert, prøv igen.");
                }
                
                // Generator

                int randomNumber = random.Next(firstIntervalLimit, secondIntervalLimit);

                while(!done)
                {
                    Console.Write("Gæt hvilket tal er rigtigt fra 1 til 10: ");
                    string secondUserInput = Console.ReadLine();
                    bool success = int.TryParse(secondUserInput, out int userNumber);
                    // Hvis tallet kan parse
                    if(success)
                    {
                        if(userNumber == randomNumber)
                        {
                            Console.WriteLine("Du gættede rigtigt. Tallet var: " + randomNumber);
                            // stopper loopet
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
}