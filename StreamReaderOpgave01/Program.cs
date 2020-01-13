using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StreamReaderOpgave01
{
    class Program
    {
        static void Main()
        {
            //Filsti til streamreader.txt
            string pathToFile = @"C:\windows\temp\streamreader.txt";
            // Kald metoden
            List<int> var = GetNumbersFromFile(pathToFile);

        }

        static List<int> GetNumbersFromFile(string path)
        {
            // liste med tal (Tom indtil videre)
            List<int> listNumbers = new List<int>();
            // Få sti til fil
            StreamReader file = new StreamReader(path);
            // gem linjer i Line
            string line;
            while((line = file.ReadLine()) != null)
            {
                //Parse string til int, tilføj til liste
                listNumbers.Add(int.Parse(line));
            }
           
            //Udprint hvert tal i listen
            int count = 1;
            for(int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i] + " #" + count);
                count++;
            }
            //Returner listen
            return listNumbers;


        }
    }
}