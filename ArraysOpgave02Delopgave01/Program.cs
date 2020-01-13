using System;

namespace ArraysOpgave02Delopgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lav et array "MyArray"
            string[] myArray = new string[] {"navn1","navn2", "navn3", "navn4","navn5" };
            // Første loop
            for(int c = 0; c < myArray.Length; c++)
            {
                // Bed om at indtaste 5 navne
                Console.Write("Indtast 5 navne: ");
                myArray[c] = Console.ReadLine();
            }
            // Anden loop
            for(int c = 0; c < myArray.Length; c++)
            {
                //print navne ud
                Console.WriteLine(myArray[c]);
            }

        }
    }
}
