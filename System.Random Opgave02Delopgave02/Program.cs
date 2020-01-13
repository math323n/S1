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

                    Console.Write("Vælg nu hvor mange sider terningerne skal have\nI intervallet 2 til 10: ");
                    string secondUserInput = Console.ReadLine();
                    bool success02 = int.TryParse(userInput, out int diceSides);
                    bool secondWhile = false;
                    while(!secondWhile)
                    {
                        if(success02)
                        {
                            if(diceSides <= 10 && diceSides >= 2)
                            {
                                for(int i = 0; i < resultDiceArray.Length; i++)
                                {
                                    Random rnd = new Random();
                                    int rndNum = rnd.Next(2, diceSides);
                                    resultDiceArray[i] = rndNum;
                                    Console.Write(resultDiceArray[i] + " ");
                                    secondWhile = true;
                                }
                            }
                            else if(diceSides < 2 || diceSides > 10)
                            {
                                Console.WriteLine("Prøv igen");
                            }
                        }
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