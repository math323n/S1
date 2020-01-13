using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StreamReaderOpgave03
{
    class Program
    {
        static List<Person> persons = new List<Person>();
        static List<string> firstNames = new List<string>();
        static List<string> lastNames = new List<string>();
        static List<int> ages = new List<int>();

       
        static void Main()
        {
            // Path to file
            string path = @"C:\Users\math323n\Documents\streamreader3.txt";
            GetTextFromFile(path);
            GetPersonsFromFile(path, out List<Person> people);
            YoungestPerson();
            OldestPerson();
            ShortestName();
            LongestFirstName();
            ShortestFirstAndLastName();
            LongestFirstAndLastName();
        }

        static bool GetTextFromFile(string path)
        {
            bool fileExists = File.Exists(path);

            if(fileExists == false)
            {
                return false;
            }


            if(fileExists == true)
            {
                // Declare StreamReader
                StreamReader documentReader = File.OpenText(path);

                // Empty string for reading document line
                string documentLine;

                // Read the next line
                // If end of line is reached, returns null
                while((documentLine = documentReader.ReadLine()) != null)
                {
                    // Split into substring
                    string[] textArray = documentLine.Split(",");
                    // Loop
                    for(int i = 0; i < textArray.Length; i += 4)
                    {
                        string text = textArray[i];
                        firstNames.Add(text);
                    }
                    // Loop
                    for(int i = 1; i < textArray.Length; i += 4)
                    {

                        string text = textArray[i];
                        lastNames.Add(text);
                    }
                    // Loop
                    for(int i = 2; i < textArray.Length; i += 4)
                    {
                        int.TryParse(textArray[i], out int sum);
                        ages.Add(sum);
                    }
                }
                return true;
            }
            return false;
        }

        // Get boxes from file    
        static bool GetPersonsFromFile(string path, out List<Person> people)
        {
            people = new List<Person>();

            // Statements
            if(GetTextFromFile(path) == true)
            {
                for(int i = 0; i != ages.Count; i++)
                {
                    Person person = new Person(firstNames[i], lastNames[i], ages[i]);
                    persons.Add(person);
                    
                }
            }
            else if(GetTextFromFile(path) == false)
            {
                // Output error if file path is incorrect
                Console.WriteLine("Forkert filsti.");
            }
            return true;
        }


        // Find youngest person & print
        static void YoungestPerson()
        {

            Person youngest = persons[0];
            foreach(Person person in persons)
            {
                if(person.Age < youngest.Age)
                {
                    youngest = person;
                }
            }
            Console.WriteLine($"Den yngste person er: {youngest.FirstName} {youngest.LastName} som er {youngest.Age}");

        }

        // Find oldest person and print
        static void OldestPerson()
        {

            Person oldest = persons[0];
            foreach(Person person in persons)
            {
                if(person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            Console.WriteLine($"Den ældste person er: {oldest.FirstName} {oldest.LastName} som er {oldest.Age}");
            
        }

        // Find shortest name of person & print
        static void ShortestName()
        {
            Person shortestFirstName = persons[0];
            foreach(Person person in persons)
            {
                if(person.FirstName.Length < shortestFirstName.FirstName.Length)
                    shortestFirstName = person;
            }
            Console.WriteLine($"Personen med det korteste navn er: {shortestFirstName.FirstName} {shortestFirstName.LastName} som er {shortestFirstName.Age}");
        }

        // Find longest name of person & print
        static void LongestFirstName()
        {
            Person longestFirstName = persons[0];
            foreach(Person person in persons)
            {
                if(person.FirstName.Length > longestFirstName.FirstName.Length)
                    longestFirstName = person;
            }
            Console.WriteLine($"Personen med det længste navn er: {longestFirstName.FirstName} {longestFirstName.LastName} som er {longestFirstName.Age}");
        }

        // Shortest first & last name 
        static void ShortestFirstAndLastName()
        {
            Person shortestFirstAndLastName = persons[0];
            foreach(Person person in persons)
            {
                if(person.FirstName.Length < shortestFirstAndLastName.FirstName.Length && person.LastName.Length < shortestFirstAndLastName.LastName.Length)
                    shortestFirstAndLastName = person;
            }
            Console.WriteLine($"Personen med det korteste navn og efternavn er: {shortestFirstAndLastName.FirstName} {shortestFirstAndLastName.LastName} som er {shortestFirstAndLastName.Age}");
        }

        // Longest first & last name 
        static void LongestFirstAndLastName()
        {
            Person longestFirstAndLastName = persons[0];
            foreach(Person person in persons)
            {
                if(person.FirstName.Length > longestFirstAndLastName.FirstName.Length && person.LastName.Length > longestFirstAndLastName.LastName.Length)
                    longestFirstAndLastName = person;
            }
            Console.WriteLine($"Personen med det længste navn og efternavn er: {longestFirstAndLastName.FirstName} {longestFirstAndLastName.LastName} som er {longestFirstAndLastName.Age}");
        }

        


    }
}