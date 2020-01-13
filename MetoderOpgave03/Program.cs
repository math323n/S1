using System;
using System.Threading;

namespace MetoderOpgave03
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            PrintMenuHeader("Hovedmenu");
            PrintThreeItems("Gå til udregninger", "Gå til tal", "Afslut programmet");
            AskForInputMenu();
            
        }
        private static void AskForInputMenu()
        {
            bool done = false;
            Console.WriteLine("Hvad vil du foretage dig?");
            Console.Write("Input: ");
            string userInput = Console.ReadLine();
            while(!done)
            {
                bool success = double.TryParse(userInput, out double number);
                if(success)
                {
                    if(number == 1)
                    {
                        calculations();
                        done = true;
                    }
                    else if(number == 2)
                    {
                        Numbers();
                        done = true;
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }
                else
                {
                    Console.WriteLine("Prøv igen");
                    AskForInputMenu();
                }
            }
        }

        // Function to check for positive numbers
        private static void IsPositive()
        {
            Console.Write("Input tal: ");
            string userInput = Console.ReadLine();
            bool success = double.TryParse(userInput, out double number);
            if(success)
            {
                if(number > 0)
                {
                    Console.WriteLine("Dit tal er positivt");
                    Thread.Sleep(3000);
                    Numbers();
                }
                else
                {
                    Console.WriteLine("Dit tal er negativt");
                    Thread.Sleep(3000);
                    Numbers();
                }
            }
            else
            {
                IsPositive();
            }
        }

        // IsEven Function for numbers
        private static void IsEven()
        {
            Console.Write("Input tal: ");
            string userInput = Console.ReadLine();
            bool success = double.TryParse(userInput, out double number);
            if(success)
            {
                // Is even
                if(number % 2 == 0)
                {
                    Console.WriteLine("Dit tal er lige");
                    Thread.Sleep(3000);
                    Numbers();
                }
                // Is not even
                else
                {
                    Console.WriteLine("Dit tal er ulige");
                    Thread.Sleep(3000);
                    Numbers();
                }
            }
            else
            {
                IsPositive();
            }
            Numbers();
        }

        // Numbers menu point
        private static void Numbers()
        {
            bool done = false;
            Console.Clear();
            Console.WriteLine("*** Tal ***");
            Console.WriteLine("1) Er tallet positivt?");
            Console.WriteLine("2) Er tallet lige?");
            Console.WriteLine("3) Tilbage til hovedmenu");
            Console.WriteLine("Hvad vil du foretage dig?");
            Console.Write("Input: ");
            string userInput = Console.ReadLine();
            while(!done)
            {
                bool success = double.TryParse(userInput, out double number);
                if(success)
                {
                    if(number == 1)
                    {
                        IsPositive();
                    }
                    else if(number == 2)
                    {
                        IsEven();
                    }
                    else if(number == 3)
                    {
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Prøv igen");
                        Numbers();
                    }
                }
                else
                {
                    Console.WriteLine("Prøv igen");
                    Numbers();
                }
            }
        }

        // print the menu header
        private static void PrintMenuHeader(string text)
        {

            Console.WriteLine("*** {0} ***", text);
        }

        // print 3 items on menu
        private static void PrintThreeItems(string text, string text2, string text3)
        {
            Console.WriteLine("1) " + text);
            Console.WriteLine("2) " + text2);
            Console.WriteLine("3) " + text3);
        }

        private static void calculations()
        {
            bool done = false;
            Console.Clear();
            Console.WriteLine("*** Udregninger ***");
            Console.WriteLine("1) Kvadrat og rod");
            Console.WriteLine("2) Tilbage til hovedmenu");
            Console.WriteLine("Hvad vil du foretage dig?");
            Console.Write("Input: ");
            string userInput = Console.ReadLine();
            while(!done)
            {
                bool success = double.TryParse(userInput, out double number);
                if(success)
                {
                    if(number == 1)
                    {
                        bool calcDone = false;
                        while(!calcDone)
                        {
                            // check for square root
                            Console.Write("Indtast tal: ");
                            string secondUserInput = Console.ReadLine();
                            bool isValid = double.TryParse(secondUserInput, out double numberForCalc);
                            if(isValid)
                            {
                                // Print square root
                                Console.WriteLine("Kvadtratroden for tallet: " + Math.Sqrt(numberForCalc));
                                Thread.Sleep(3000);
                                calculations();
                            }
                            else
                            {
                                Console.WriteLine("prøv igen");
                                calculations();
                            }
                        }
                        
                    }
                    else if(number == 2)
                    {
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Prøv igen");
                        calculations();
                    }
                }
                else
                {
                    Console.WriteLine("Prøv igen");
                    calculations();
                }
            }
        }
    }
}