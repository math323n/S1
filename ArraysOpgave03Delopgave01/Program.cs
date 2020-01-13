using System;
using System.Linq;

namespace ArraysOpgave03Delopgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Tæller
            int counter = 0;
            bool isDone = false;
            bool loopDone = false;
            // For loop
            while(!isDone)
            {
                // Input
                Console.Write("I intervallet 1-25. Indtast hvor mange varer du vil indtaste prisen på: ");
                string firstUserInput = Console.ReadLine();
                // Parse string input til int
                int.TryParse(firstUserInput, out int outputNum);
                while(!loopDone)
                {


                    if(outputNum >= 1 && outputNum <= 25)
                    {
                        loopDone = true;

                    }
                    // Nedenstående kode er til at tjeke om det er i intervallet. (1-25)
                    else if(outputNum < 1 || outputNum > 25)
                    {
                        Console.WriteLine("Ugyldig værdi, prøv igen");
                        continue;
                    }

                }

                
                int[] myArray = new int[25];
                int[] myArray2 = myArray[0..outputNum];
                for(int c = 0; c < myArray2.Length; c++)
                {
                    Console.Write("Indtast pris: ");
                    string secondUserInput = Console.ReadLine();

                    int.TryParse(secondUserInput, out int outputPrice);


                    if(outputPrice < 0 || outputPrice >= 20001)
                    {
                        Console.WriteLine("Ugyldig værdi, prøv igen");
                    }
                    else if(outputPrice >= 1 && outputPrice <= 20000)
                    {
                        myArray2[c] = outputPrice;
                        counter++;

                    }

                }
                if(counter <= outputNum)
                {

                    // Få summen
                    double sum = myArray2.Sum();
                    // Momsen = 25%
                    double moms = 25;
                    // Træk moms fra sum
                    double momsResult = sum / 100 * moms;
                    // Få gennemsnits beløb af tallene
                    double average = myArray2.Average();
                    // totale pris
                    double totalPrice = sum + momsResult;
                    Console.WriteLine("+-----------------------------+");
                    Console.WriteLine("Gennemsnitsprisen er: " + average);
                    Console.WriteLine("Den samlede moms: " + momsResult);
                    Console.WriteLine("Den samlede pris inkl moms: " + totalPrice);

                    isDone = true;


                }
            }
           

        }
    }
}