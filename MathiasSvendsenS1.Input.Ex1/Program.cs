using System;

namespace MathiasSvendsenS1.Input.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsol vindue titel : Console window title
            Console.Title = "Input fra konsollen";

            // Konsol farver : Console colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            
            // Delopgave 01
            Console.WriteLine("+--- Delopgave 01 ---+");
            Console.WriteLine("Indtast navn:");
            string input = Console.ReadLine();
            Console.WriteLine("Hej " + input + ". Godt at se dig!");
            Console.WriteLine("+--------------------+");
            Console.WriteLine("Tryk en tast for at fortsætte programmet...");
            Console.ReadKey();
            


            // Delopgave 02
            
            Console.Clear();
            Console.WriteLine("+--- Delopgave 02 ---+");
            Console.WriteLine("Hvad hedder du?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hvor gammel er du?");
            string inputAge = Console.ReadLine();
            Console.WriteLine("Hvor bor du?");
            string inputLocation = Console.ReadLine();
            Console.WriteLine("Du hedder: " + inputName + ". Du er: " + inputAge + " år. Din adresse er: " + inputLocation);
            Console.WriteLine("+--------------------+");
            Console.WriteLine("Tryk en tast for at fortsætte programmet...");
            Console.ReadKey();
            

            
            // Delopgave 03
            Console.WriteLine("\n+--- Delopgave 03 ---+");
            Console.WriteLine("skriv et bogstav");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine("\nDu indtastede bogstavet: " + inputChar);
            Console.WriteLine("+--------------------+");
            Console.WriteLine("Tryk en tast for at fortsætte programmet...");
            Console.ReadKey();
            Console.Clear();
            



    
            
            // Delopgave 04
             

            Console.WriteLine("+--- Delopgave 04 ---+");
            Console.WriteLine("Indtast din alder: ");

            /* Loop der genstarter medmindre et tal er skrevet.
             * Loop that resets unless a number is typed. */
            
             var retry = true;
             while(retry)

             {
                 var inputAge2 = Console.ReadLine();
                 if(int.TryParse(inputAge2, out int number1))
                 {
                     Console.WriteLine($"Utroligt! Er du virkelig kun {number1} år?");
                     retry = false;
                 }
                 else
                 {
                     Console.WriteLine($"{inputAge2} er ikke et tal, prøv igen.");
                 }

             }

             Console.WriteLine("+--------------------+");

             Console.WriteLine("Tryk en tast for at fortsætte programmet...");
             Console.ReadKey();

            // Delopgave 05
            Console.WriteLine("\n+--- Delopgave 05 ---+");
            Console.WriteLine("Indtast din lokation");
            string inputLocation2 = Console.ReadLine();
         
            Console.WriteLine("Indtast temperaturen");
            string inputTemp = Console.ReadLine();
           
            //double.TryParse(inputTemp, out double temp);
            string input2 = string.Format("{0:n0}", inputTemp);
            Console.WriteLine($"{inputTemp} er da en fin temperatur for " + inputLocation2);
        }
    }
}
