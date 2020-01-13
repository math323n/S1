using System;
using System.Threading;

namespace KontrolstrukturWhileLoopOpgave07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 07 - Kontrolstruktur while loop
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur while loop 07";
            /*-------------------------------------------*/
            
            string input = "";
            do
            {
                Console.WriteLine("Skriv exit for at stoppe programmet");
                input = Console.ReadLine();
            } while(input != "exit");



            for(int i = 0; i <= 9; i = i + 1)
            {
                Console.WriteLine(i);
            }

            Thread.Sleep(3000);
            Console.Clear();

            int[] myArray = new int[10] { 1, 2, 3, 4, 5 ,6, 7, 8, 9, 10 };

            for(int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }



        }

    }
}
