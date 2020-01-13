using System;

namespace ArraysOpgave02Delopgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array med bools, default value er altid false
            bool[] myParkingSpots = new bool[10];

            // tæller
            int numberCounter = 1;
            // Ledige pladser
            int availableParkingSpot= 0;
            // For loop
            for(int i = 0; i < myParkingSpots.Length; i++)
            {
                // Write
                Console.Write("\nEr parkeringsplads " + numberCounter 
                    + " ledig?" + "\nJa eller nej: ");
                numberCounter++;
                //Få input
                string userInput = Console.ReadLine().ToLower();
                //Hvis skriver "ja"
                if(userInput == "ja")
                {
                    // erklær som True
                    myParkingSpots[i] = true;
                    // Tilføj en ledig plads
                    availableParkingSpot++;
                }
                // hvis indtaster "nej"
                else if(userInput == "nej")
                {
                    // Sæt til false hvis ingen plads.
                    myParkingSpots[i] = false;
                   
                }
                // Ellers
                else
                {
                    Console.WriteLine("Du skal indtaste ja eller nej");
                }
               
            }

            Console.WriteLine("Det ser ud til at der er " + availableParkingSpot + " ledige pladser");
            Console.ReadLine();
        }
    }
}
