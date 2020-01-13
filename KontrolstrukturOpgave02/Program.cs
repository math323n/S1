using System;

namespace KontrolstrukturOpgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Få brugerens alder
            Console.Write("Indtast din alder: ");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int outputAge);

            

            // If 
            if(outputAge >= 18)
            {
                Console.WriteLine("Du er myndig\nFarvel");
            }
            
            
            










        }
    }
}
