using System;

namespace System.Random_Opgave01Delopgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[5];

            for(int i = 0; i < numbersArray.Length; i++)
            {
                Random rnd = new Random();
                int rndNum = rnd.Next(-10, 11);
                numbersArray[i] = rndNum;
                Console.Write(numbersArray[i] + " ");
            }
        }
    }
}
