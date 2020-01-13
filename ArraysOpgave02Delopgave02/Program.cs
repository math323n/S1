using System;
using System.Linq;

namespace ArraysOpgave02Delopgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            // erklær en array til 10 tal.
            int[] numberArray = new int[] {0,1,2,3,4,5,6,7,8,9};

            for(int i = 0; i < numberArray.Length; i++)
            {
                // Bed om at indtaste tal på højder
                Console.Write("Indtast højden på noget: ");
              
                // Få input og gem i array
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int outputNumber);
                numberArray[i] = outputNumber;
            }
            for(int i = 0; i < numberArray.Length; i++)
            {
                // Print tallene
                Console.WriteLine(numberArray[i]);
                
            }
            // Udprint gennemsnitshøjden
            int sum = numberArray.Sum();
            Console.WriteLine("Gennemsnitshøjde er: " + sum / 10.0);

        }
    }
}