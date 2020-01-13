using System;
using System.IO;
using System.Text;

namespace StreamWriterOpgave01
{
    class Program
    {
        static string path = @"C:\Users\math323n\Documents\Logbog";
        static string completePath = "";
        static DateTime currentTime = DateTime.Now;
        static void Main()
        {
            Menu();
        }

        // Menu 
        static void Menu()
        {
            Console.Write(
                "Velkommen til Logbogen.\n" +
                "Indtast et filnavn: "
                );
            string fileName = Console.ReadLine();
            completePath = path + @"\" + fileName + ".txt";
            if(CheckFileName(completePath) == false)
            {
                // Create Streamwriter object
                using (StreamWriter writer = new StreamWriter(completePath, false, Encoding.Default))
                {
                    // Writing...
                    string text = StreamWriterWriting();
                    writer.WriteLine(currentTime + ": " +  text);

                }
            }
            else
            {
                Console.WriteLine("Skriv et andet filnavn.");
                Menu();
            }

        }

        // Check file name
        static bool CheckFileName(string path)
        {
            
            bool fileExists = File.Exists(path);
            if(fileExists == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        // Write to file
        static string StreamWriterWriting()
        {
            Console.WriteLine("Skriv din tekst her:\n");
            string userText = Console.ReadLine();
            return userText;
        
        }
    }
}
