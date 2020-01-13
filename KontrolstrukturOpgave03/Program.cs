using System;

namespace KontrolstrukturOpgave03
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
            
            bool programDone = false;
            bool programTwoDone = false;
            while(!programDone)
            {
                // Få brugerens tal
                Console.Write("Indtast et tal: ");
                string firstUserInput = Console.ReadLine();
                double.TryParse(firstUserInput, out double firstOutputNumber);

                Console.Write("Indtast et tal: ");
                string secondUserInput = Console.ReadLine();
                double.TryParse(secondUserInput, out double secondOutputNumber);


                
                if(firstOutputNumber == 0)
                {
                    // Divide by zero error handling
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("ERROR: Man kan ikke dividere med 0!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(firstOutputNumber == 926)
                {
                    programDone = true;
                }
                else if(secondOutputNumber == 0)
                {
                    // Divide by zero error handling
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("ERROR: Man kan ikke dividere med 0!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(firstOutputNumber == secondOutputNumber)
                {
                    Console.WriteLine("De tal er ens");
                    Console.WriteLine("Tallene divideret er: " + firstOutputNumber / secondOutputNumber);
                }
                
                else if(firstOutputNumber != secondOutputNumber)
                {
                    Console.WriteLine("De tal er ikke ens");
                    Console.WriteLine("Tallene divideret er: " + firstOutputNumber / secondOutputNumber);
                }
                while(!programTwoDone)
                {
                    
                    // Få brugerens tal
                    Console.Write("Indtast et beløb: ");
                    string firstUserInputValue = Console.ReadLine();
                    double.TryParse(firstUserInputValue, out double firstOutputNumberValue);
                    firstOutputNumberValue *= 1.25;

                    if (firstOutputNumberValue <= 0)
                    {
                        Console.WriteLine("Beløbet skal være over 0");
                    }
                    else if(firstOutputNumberValue > 0)
                    {
                        Console.WriteLine("Beløbet med moms er: " + firstOutputNumberValue);
                    }
                    
                }
                

                


            }
            


        
        }
    }
}
