using System;


namespace KontrolstrukturWhileLoopOpgave04
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().ToLower();
            while (userInput != "exit")
            {
                
                Console.WriteLine(userInput);
            }
            Environment.Exit(0);
        }
    }
}
