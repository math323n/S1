using System;

namespace S1StrengeOpgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsol indstillinger : Console settings
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);

            Console.Write("Indtast dit fornavn: ");
            string inputFirstName = Console.ReadLine();
            Console.WriteLine("Indtast dit efternavn: ");
            string inputLastName = Console.ReadLine();
            Console.WriteLine(
           "Fornavn og efternavn initialerne er: "+ inputFirstName[0] + inputLastName[0]);
        }
    }
}
