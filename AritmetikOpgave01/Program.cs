using System;

namespace AritmetikOpgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 01 - Aritmetik
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Aritmetik 01";
            
            // Eklær variabler
            string firstNumString = "12";
            string secondNumString = "34";

            string numStringCombined = string.Concat(firstNumString, secondNumString);

            int firstNumInt = 12;
            int secondNumInt = 34;
            int bothIntCombined = firstNumInt + secondNumInt;
            //Print ud
            Console.WriteLine
                ("Tekst lagt sammen er: " + numStringCombined +  "\nTal lagt sammen er: "
                + bothIntCombined + "\nTekst og tal lagt sammen er: " 
                + numStringCombined + bothIntCombined);
          
        }
    }
}
