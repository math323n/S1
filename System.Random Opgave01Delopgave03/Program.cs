using System;

namespace System.Random_Opgave01Delopgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] numbersArray = new double[5];

            for(int i = 0; i < numbersArray.Length; i++)
            {
                Random rnd = new Random();
                double rndNumbers = rnd.NextDouble();
                numbersArray[i] = rndNumbers;
                Console.Write(numbersArray[i] + " ");
            }
            

           

        }
    }
}
