using System;

namespace ClassOpgave01
{
    class Program
    {
        static void Main()
        {
           // Nyt box objekt, W = 20, H = 40, L = 60 
           Box myBox = new Box(20, 40, 60);

            // Print info om kassens dimensioner
            myBox.CalculateSurface();
            myBox.PrintInfo();
        }

    }
}