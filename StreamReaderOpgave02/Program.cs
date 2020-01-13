using StreamReaderOpgave02;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Opgave02Boxes
{
    class Program
    {

        static List<Box> boxes = new List<Box>();
        static List<int> height = new List<int>();
        static List<int> length = new List<int>();
        static List<int> width = new List<int>();
        static List<int> volumes = new List<int>();
        static List<int> surfaces = new List<int>();

        static void Main()
        {
            // Path to file
            string path = @"C:\Users\math323n\Documents\streamreader.txt";
            if(GetBoxesFromFile(path, out List<Box> boxes) == true)
            {
                int maxVolumeValue;
                int minVolumeValue;
                int maxSurfaceValue;
                int minSurfaceValue;
                for(int i = 0; i != height.Count; i++)
                {
                    Box box = new Box(height[i], length[i], width[i]);
                    boxes.Add(box);

                }
                foreach(Box box in boxes)
                {

                    Console.WriteLine(
                        $"Surface: {Box.CalculateSurfaceArea(box)} cm2 \n" +
                        $"Volume: {Box.CalculateVolume(box)} cm³\n" +
                        $"Længde: {box.Length} cm\n" +
                        $"Højde: {box.Height} cm\n" +
                        $"Længde: {box.Width} cm\n");
                    int volume = Box.CalculateVolume(box);
                    int surface = Box.CalculateSurfaceArea(box);
                    volumes.Add(volume);
                    surfaces.Add(surface);
                }
                maxVolumeValue = volumes.Max();
                minVolumeValue = volumes.Min();
                maxSurfaceValue = surfaces.Max();
                minSurfaceValue = surfaces.Min();
                Console.WriteLine(
                    $"Den højeste volume er: {maxVolumeValue}\n" +
                    $"Den mindste volume er: {minVolumeValue}\n" +
                    $"Den højeste overflade areal er: {maxSurfaceValue}\n" +
                    $"Den mindste overflade areal er: {minSurfaceValue}"
                    );
                Console.ReadLine();
            }
            


        }

        // Get numbers from file
        static bool GetNumbersFromFile(string path)
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
                    string[] numberArray = documentLine.Split(",");
                    // Loop
                    for(int i = 0; i < numberArray.Length; i += 4)
                    {
                        int.TryParse(numberArray[i], out int sum);
                        height.Add(sum);
                    }
                    // Loop
                    for(int i = 1; i < numberArray.Length; i += 4)
                    {
                        int.TryParse(numberArray[i], out int sum);
                        length.Add(sum);
                    }
                    // Loop
                    for(int i = 2; i < numberArray.Length; i += 4)
                    {
                        int.TryParse(numberArray[i], out int sum);
                        width.Add(sum);
                    }
                }
                return true;
            }
            return false;
        }

        // Get boxes from file    
        static bool GetBoxesFromFile(string path, out List<Box> boxes)
        {
            boxes = new List<Box>();

            // Statements
            if(GetNumbersFromFile(path) == true)
            {
                for(int i = 0; i != height.Count; i++)
                {
                    Box box = new Box(height[i], length[i], width[i]);
                    boxes.Add(box);

                }
            }
            else if(GetNumbersFromFile(path) == false)
            {
                // Output error if file path is incorrect
                Console.WriteLine("Forkert filsti.");
            }
            return true;
        }
    }
}