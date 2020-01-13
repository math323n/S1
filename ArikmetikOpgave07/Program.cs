using System;

namespace ArikmetikOpgave07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 07 - Aritmetik
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Aritmetik 07";
            /*-------------------------------------------*/


            // Få input fra brugeren
            Console.Write("Indtast et tal på en højde: ");
            double userInput01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast et tal på en højde: ");
            double userInput02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast et tal på en højde: ");
            double userInput03 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast et tal på en højde: ");
            double userInput04 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast et tal på en højde: ");
            double userInput05 = Convert.ToDouble(Console.ReadLine());
            double resultat = userInput01 + userInput02 + userInput03 + userInput04 + userInput05;

            Console.WriteLine("Gennemsnitshøjden er: " + resultat / 5);





        }
    }
}
