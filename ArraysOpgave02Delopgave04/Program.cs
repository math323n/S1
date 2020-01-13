using System;

namespace ArraysOpgave02Delopgave04
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            // Erklær array
            double[] myNumberArray = new double[5];

            for(int i = 0; i < myNumberArray.Length; i++)
            {   // Input
                Console.Write("indtast 5 tal, også med decimaler: ");

                string userInput = Console.ReadLine();
                // parse input til double
                double.TryParse(userInput, out double outputNumber);
                // Tilføj til array
                myNumberArray[i] = outputNumber;
            }

            for(int i = myNumberArray.Length - 1; i >= 0; i--)
            {
               
                //Udskriv array
                Console.WriteLine("tallet " + counter + " er: " + myNumberArray[i]);
                counter++;
            }
            Console.ReadLine();
        }
    }
}
