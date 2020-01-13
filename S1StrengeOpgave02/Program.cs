using System;
// Opgave 02
namespace S1StrengeOpgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsol indstillinger : Console settings
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);

            Console.Write("Indtast bogstaver: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Du har indtastet " + userInput.Length + " antal bogstaver");
        }
    }
}
