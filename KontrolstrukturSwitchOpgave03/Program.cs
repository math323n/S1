using System;

namespace KontrolstrukturSwitchOpgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 03 - Kontrolstruktur switch
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Kontrolstruktur switch 03";
            /*-------------------------------------------*/

            Console.Write("Tryk på en tast: ");
            ConsoleKeyInfo keyPress = Console.ReadKey();

            switch(keyPress.Key)
            {
                case ConsoleKey.A:
                case ConsoleKey.E:
                case ConsoleKey.I:
                case ConsoleKey.O: 
                case ConsoleKey.U:
                    Console.WriteLine("\nDu trykkede på en vokal");
                    break;

                case ConsoleKey.B:
                case ConsoleKey.C:
                case ConsoleKey.D:
                case ConsoleKey.F:
                case ConsoleKey.G:
                case ConsoleKey.H:
                case ConsoleKey.J:
                case ConsoleKey.K:
                case ConsoleKey.L:
                case ConsoleKey.M:
                case ConsoleKey.N:
                case ConsoleKey.P:
                case ConsoleKey.Q:
                case ConsoleKey.R:
                case ConsoleKey.S:
                case ConsoleKey.T:
                case ConsoleKey.V:   
                case ConsoleKey.W:  
                case ConsoleKey.X:      
                case ConsoleKey.Y:
                case ConsoleKey.Z:
                    Console.WriteLine("\nDu trykkede på en konsonant");
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                   break;
                default:
                    Console.WriteLine("Ukendt tastetryk");
                    break;


            }
         


        }
    }
}
