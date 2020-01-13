using System;
//Lav et program der anvender for loop til at udskrive alle lige tal i intervallet [1;20] 
namespace KontrolstrukturForLoopOpgave01Delopgave03
{
   
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
               
            }
        }
    }
}
