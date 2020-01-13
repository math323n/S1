using System;
/*Lav et program der kan tælle fra x til y. 
Bed brugeren skrive hvor talrækken skal starte (x-værdien), og hvor den skal slutte 
(y-værdien). Hvis x er større end y, så skal brugeren have en fejlbesked. */
namespace ForLoopDelopgave05
{
    class Program
    {
        static void Main()
        {
            bool done = false;
            Console.Write("Hvor skal talrækken starte? ");
            string firstUserInput = Console.ReadLine();
            int.TryParse(firstUserInput, out int firstOutputNumber);

            Console.Write("Hvor skal talrækken afslutte? ");
            string secondUserInput = Console.ReadLine();
            int.TryParse(secondUserInput, out int secondOutputNumber);

            while(!done)
            {
                if(firstOutputNumber > secondOutputNumber)
                {
                    Console.WriteLine("Fejl, start må ikke være mere end afslutning.");
                }
                else
                {
                    for(int i = firstOutputNumber; i < secondOutputNumber; i++)
                    {

                        Console.WriteLine(i);
                        done = true;

                    }

                }


            }

        }
    }
}
