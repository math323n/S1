using System;
using System.Linq;

namespace KontrolstrukturWhileLoopOpgave05
{
    class Program
    {
        static void Main(string[] args)
        {
            


            while(true)
            {
                Console.WriteLine("Indtast et tal mindre end 11, men større end 0. For at stoppe");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int outputNumber);

                // Check om tallet er i rækkevidde 1 til 10
                if(outputNumber > 0 && outputNumber < 11)
                {
                    Console.WriteLine("Du har indtastet rigtigt");
                    break;
                }
            }
        }
    }
}
