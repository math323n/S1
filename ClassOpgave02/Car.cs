using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOpgave02
{
    class Car
    {
        // Fields 
        string make;
        string model;
        string color;
        double price;
        bool isSold;
        bool isOnSale;


        // Constructor
        public Car(string make, string model, string color, double price, bool isSold)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            IsOnSale = false;
        }

        // Properties
        // Mærke
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        // Model
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        // Farve
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        // Pris
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        // Er solgt?
        public bool IsSold
        {
            get
            {
                return isSold;
            }
            set
            {
                isSold = value;
            }
        }
        // Is on sale
        public bool IsOnSale
        {
            get
            {
                return isOnSale;
            }
            set
            {
                isOnSale = value;
            }
        }

        // Metoder
        // Print info om bil
        public void PrintInfo()
        {
            if(IsSold == false)
            {
            Console.WriteLine($"Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.");
            }
            else
            {
                Console.WriteLine($"SOLGT! Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.");
            }
        }
        // Tostring
        public override string ToString()
        {
            return $"{Make} {Model}";
        }

        // Sæt til salg
        public void PutOnSale()
        {
            if(IsOnSale == false)
            {
                IsOnSale = true;
               
                price = price * 0.9;
            } 
        }
    }
}