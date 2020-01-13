using System;
using System.Threading;

namespace DateTimeOpgave03Delopgave01
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            bool LeapYear = false;
            Console.Clear();
            Console.Write("Indtast året i dag: ");
            if(int.TryParse(Console.ReadLine(), out int currentYear))
            {
                //Fejl besked
                if(currentYear == 0 || currentYear > 9998)
                {
                    Console.WriteLine("Prøv igen.");
                    Thread.Sleep(2500);
                    Main();
                }
                else
                {
                    // Skudår kode
                    while(!LeapYear)
                    {
                        currentYear++;
                        LeapYear = DateTime.IsLeapYear(currentYear);

                    }
                    // Print resultatet til brugeren
                    Console.WriteLine("Næste skudår er: " + currentYear);
                    Thread.Sleep(2500);
                    Main();
                }
            }
            // Fejlbesked 
            else
            {
                Console.WriteLine("Prøv igen.");
                Thread.Sleep(2500);
                Main();
            }
        }
    }
}