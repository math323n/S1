using System;

namespace S1StrengeOpgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;

            // Konsol indstillinger : Console settings
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
           


            Console.Write("Indtast dit fornavn: ");
            firstName = Console.ReadLine();
            Console.Write("Indtast dit efternavn: ");
            lastName = Console.ReadLine();
            
            Console.WriteLine("Alt med stort: " + firstName.ToUpper() + " " + lastName.ToUpper()
               + "\nAlt med småt: " + firstName.ToLower() + " " + lastName.ToLower()); 
        }
       
    }
}
