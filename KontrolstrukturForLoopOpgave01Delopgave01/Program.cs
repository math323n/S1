using System;
// Kontrolstruktur for loop opgave 01
/* Lav et program der anvender for loop til at
 * udskrive heltallene i intervallet [1;10] baglæns */
namespace KontrolstrukturForLoopOpgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Udskriver fra 10 til 0 baglæns 
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i + ": " + "Hello Horld!");
            }
        }
    }
}
