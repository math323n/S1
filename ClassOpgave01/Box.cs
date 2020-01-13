using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOpgave01
{
    class Box
    {
        // Fields
        private int width;
        private int height;
        private int length;
        private int surface;

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
        public  int Height
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
            set {
                length = value; 
            }
        }
        // Volume
        public int Surface
        {
            get
            {
                return surface;
            }
            set
            {
                surface = value;
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
            Console.WriteLine($"Rumfang:   {Surface} m3");
        }

        // Udregn kassens rumfang
        public void CalculateSurface()
        {
            surface = height * length * width;
        }
    }
}