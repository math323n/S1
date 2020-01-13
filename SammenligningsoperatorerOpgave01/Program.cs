using System;

namespace SammenligningsoperatorerOpgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 02 - Sammenligningsoperatorer 
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Sammenligningsoperatorer 02";
            /*-------------------------------------------*/
            //Program færdig = false
            bool done = false;

            //While loop
            while(!done)
            {

                // Få månedsløn og gang det med 12
                Console.Write("Indtast din månedsløn: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int outputInt);
                
                // Print årsløn
                Console.WriteLine("Din årsløn er: " + outputInt * 12);
                // Angiv årsløn som yearlySalary
                int yearlySalary = outputInt * 12;

                // Få husets pris
                Console.WriteLine("Indtast prisen på et hus, du vil have: ");
                string userInputPrice = Console.ReadLine();
                int.TryParse(userInputPrice, out int priceForHouse);

                // Angiv procentdel
                int percentage = 20;
                // Få 20 % af husets pris
                int resultPrice = priceForHouse * percentage / 100;


                // HVIS årslønnen er OVER eller LIGE med 20% af husets pris
                if(yearlySalary >= resultPrice)
                {
                    Console.WriteLine("Du kan købe huset. " + "20% af prisen på huset er " + resultPrice);
                    //done = true;
                }
                if (yearlySalary < resultPrice)
                {
                    Console.WriteLine("Du har ikke råd, du er fattig.");

                }

               

            }



        }
    }
}
