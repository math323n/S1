using System;
using System.Collections.Generic;

namespace System.Random_Opgave02Delopgave02
{
    class Program
    {
        static void Main()
        {
            bool done = false;
            int[] numbersArray = new int[999];
            while(!done)
            {
                Console.Write("\nVælg hvor mange terninger der skal kastes: ");

                string userInput = Console.ReadLine();
                bool success = int.TryParse(userInput, out int outputNum);
                if(success)
                {
                    int[] resultDiceArray = numbersArray[0..outputNum];

                    for(int i = 0; i < resultDiceArray.Length; i++)
                    {
                        Random rnd = new Random();
                        int rndNum = rnd.Next(1, 7);
                        resultDiceArray[i] = rndNum;
                        Console.Write(resultDiceArray[i] + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Forkert input, prøv igen.");
                }

            }

        }
    }
}