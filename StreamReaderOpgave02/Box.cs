using System;
using System.Collections.Generic;
using System.Text;

namespace StreamReaderOpgave02
{
    class Box
    {
        // Fields
        private int width;
        private int height;
        private int length;

        // Constructor
        public Box(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        // Properties
        // Width
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        // Height
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        // Length
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }


        // Metoder
        // Print information om kassen
        public void PrintInfo()
        {
            Console.WriteLine("Kassen har følgende mål: ");
            Console.WriteLine($"Højde:     {Height} cm");
            Console.WriteLine($"Længde:    {Length} cm");
            Console.WriteLine($"Bredde:    {Width} cm");
        }

        // Calculate volume of box object.
         public static int CalculateVolume(Box box)
        {
            int volume = box.Height * box.Length * box.Width;
                            
            return volume;
        }

        // Calculate surface area of box object.
        public static int CalculateSurfaceArea(Box box)
        {
            int surface = 2 * (box.height * box.width + box.width * box.length + box.height * box.length);

            return surface;
        }
         

    }
}
