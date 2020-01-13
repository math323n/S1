using System;

namespace S1StrengeOpgave04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsol indstillinger : Console settings
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);

            // Spørg om fornavn og efternavn : Ask for first and last name
            Console.Write("Indtast dit fornavn: ");
            string inputFirstName = Console.ReadLine();
            Console.Write("Indtast nu dit efternavn: ");
            string inputLastName = Console.ReadLine();

           
            Console.WriteLine(inputFirstName.ToUpper() + " " + inputLastName.ToUpper());
            Console.WriteLine(inputFirstName.ToLower() + " " + inputLastName.ToLower());
            Console.WriteLine($""+ inputFirstName[0] + inputLastName[0]);
            Console.ReadLine();
        }
    }
}
