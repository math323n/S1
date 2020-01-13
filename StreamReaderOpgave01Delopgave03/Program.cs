using System;
using System.Collections.Generic;
using System.IO;

namespace StreamReaderOpgave01
{
    class Program
    {
        static void Main()
        {
            //Filsti til streamreader.txt
            string pathToFile = @"C:\windows\temp\streamreader.txt";
            List<int> listNumbers = new List<int>();
            // Kald metoden
            bool exist = GetNumbersFromFile(pathToFile, out listNumbers);
            Console.WriteLine("Eksisterer filen? " + exist);
        }
   
        static bool GetNumbersFromFile(string path, out List<int> numbers)
        {

            // liste med tal (Tom indtil videre)
            List<int> numberList = new List<int>();
            bool exist = File.Exists(path);
            if(exist == true)
            {
                // Få sti til fil
                StreamReader file = new StreamReader(path);
                // gem linjer i Line
                string line;

                while((line = file.ReadLine()) != null)
                {
                    string[] numberArray = line.Split("\t");
                    for(int i = 0; i < numberList.Count; i++)
                    {
                        //Parse til array
                        int.TryParse(numberArray[i], out int sum);
                        numberList.Add(sum);
                    }
 
                    //Print tallene
                    for(int i = 0; i < numberArray.Length; i++)
                    {
                        Console.WriteLine(numberArray[i]);
                    }
                }
            }
            numbers = null;
            return exist;
        }
    }
}