using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetoderParameterDelopgave01
{
    class Program
    {
        static void Main()

        {

           int[] inputArray = new int[] {1,4,33,0,9 };
            int numberSum = CalcSum(15, 20, 30);
            Console.WriteLine(numberSum);
            Console.Write("Indtast en streng nu: ");
            string userInput = Console.ReadLine();
            char[] charArray = userInput.ToCharArray();
            string stringMethod = Concatenate(charArray);
            Console.WriteLine(stringMethod);

            string concatenate = ConcatenateString("Hej", " ggo  dag", "aut ist");
            Console.WriteLine(concatenate);

            PrintWelcome("Hej Verden");
            SetFirstCharToUpper("hJEEEEEE");
            AddVat(25);
            bool isZero = ContainsZeros(inputArray);
            Console.WriteLine("Er der 0 taller? " + isZero);
        }

        // metode til at lægge tal sammen
        private static int CalcSum(params int[] listNumbers)
        {
            int sum = listNumbers.Sum();
            return sum;
        }

        // Sammensæt alle input karaktererne til en string. 
        private static string Concatenate(params char[] inputStringList)
        {
            string stringUser = "";
            for(int i = 0; i < inputStringList.Length; i++)
            {
                stringUser += inputStringList[i].ToString();
            }
            return stringUser;
        }

        //Sammensæt alle input strengene til en string ad-skilt af mellemrum. 
        private static string ConcatenateString(params string[] stringInput)
        {
            string str = "";
            string stringUser = "";
            for(int i = 0; i < stringInput.Length; i++)
            {
                stringUser += stringInput[i];
            }
            str = stringUser.Replace(" ", String.Empty);
            return str;
        }

        /*kriv Hello World på det sprog som defineres af input.
        Understøt mindst fem forskellige sprog */
        private static void PrintWelcome(string optionalString = "da")
        {
            string russian = "Privet Mir";
            string french = "Bonjour Le Monde";
            string english = "Hello World";
            string german = "Hallo Welt";

            Console.WriteLine(optionalString);
            Console.WriteLine(russian);
            Console.WriteLine(french);
            Console.WriteLine(english);
            Console.WriteLine(german);
        }

        /*Ændr det første tegn i input strengen til at være et stort tegn, 
         hvis input strengen har mindst 1 tegn */
         private static void SetFirstCharToUpper(string stringInput)
        {
            string text = "";
                
            text = char.ToUpper(stringInput[0]) + stringInput.Substring(1).ToLower();
            Console.WriteLine(text);
        }

        private static void AddVat(double inputValue, double optional = 1.25)
        {
            double total = inputValue * optional;
            Console.WriteLine(total);
        }

        /*Tæl hvor mange 0’er der findes i input arrayet. 
         * Returner en boolean der indikerer om der var 
         * Returner en boolean der indikerer om der var 0’er eller ej. 
         * Returner via out parameteren hvor mange 0’er der blev fundet. */
         private static bool ContainsZeros(int[] intArray)
        {
            bool hasZeros = false;
            for (int i = 0; i < intArray.Length; i++)
            {
                if(intArray[i] == 0)
                {
                    hasZeros = true;
                }
            }
            return hasZeros;
        }
    }
}