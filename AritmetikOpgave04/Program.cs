using System;

namespace AritmetikOpgave04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 04 - Aritmetik
            // Konsol indstillinger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(80, 30);
            Console.Title = "Aritmetik 04";
            /*-------------------------------------------*/

            int firstNumber = 10;
            int secondNumber = 3;
            double doubleFirstNumber = firstNumber;
            double doubleSecondNumber = secondNumber;
            double resultOfInt01 = firstNumber / secondNumber;
            double resultOfInt02 = doubleFirstNumber / doubleSecondNumber;


            Console.WriteLine(
            "Division med int datatype gemt i en double\n10 / 3 = " + resultOfInt01);

            Console.WriteLine("\nDivision med konverterede int til double datatype:\n" +
             doubleFirstNumber.ToString() + " / " + doubleSecondNumber.ToString() + " = " +
             resultOfInt02);

            Console.WriteLine("\nForkortet til to decimaler:\n" +
            "{0} / {1} = {2,2:f}", doubleFirstNumber, doubleSecondNumber, resultOfInt02);

            Console.WriteLine("\nModulus:\n" + firstNumber.ToString() + " % " + 
            secondNumber.ToString() +" = " + firstNumber % secondNumber);
            
        }
    }
}
