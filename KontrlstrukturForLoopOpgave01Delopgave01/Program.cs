using System;
// Kontrolstruktur for loop opgave 01
/* Lav et program der anvender for loop til at udskrive heltallene i intervallet [1;10] */
namespace KontrolstrukturForLoopOpgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + ": " + "Hello Horld!");
            }
        }
    }
}
