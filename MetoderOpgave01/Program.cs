using System;

namespace MetoderOpgave01
{
    class Program
    {

        static void Main()
        {
            // første kode
            Console.Write("Indtast tal 1: ");
            double firstUserInput = double.Parse(Console.ReadLine());
            Console.Write("Indtast tal 2: ");
            double secondUserInput = double.Parse(Console.ReadLine());
            PrintResult(firstUserInput, secondUserInput);
            // anden kode
            Console.Write("Indtast : ");
            double thirdUserInput = double.Parse(Console.ReadLine());

            Print();
            Print(2);
            IsPositive(7);
        }
        private static void Print()
        {
            Console.WriteLine("Hello World!");
        }

        private static void Print(int number)
        {
            Console.WriteLine("tallet er: " + number);
        }
        private static bool IsPositive(int isZero)
        {
            if(isZero == 0)
            {
                return true;
            }
            return false;
        }                                                           

       private static void PrintResult(double firstNumber, double secondNumber)
        {
            double addedTogether = firstNumber + secondNumber;
            double subtracted = firstNumber - secondNumber;
            double multiplied = firstNumber * secondNumber;
            double divided = firstNumber / secondNumber;
            Console.WriteLine("Tal " + firstNumber + " + " + secondNumber + " er " + addedTogether);
            Console.WriteLine("Tal " + firstNumber + " - " + secondNumber + " er " + subtracted);
            Console.WriteLine("Tal " + firstNumber + " * " + secondNumber + " er " + multiplied);
            Console.WriteLine("Tal " + firstNumber + " / " + secondNumber + " er " + divided);     
        }
    }
}