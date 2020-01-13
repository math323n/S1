using System;
using System.Linq;

namespace System.Random_Opgave03Delopgave01
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            

            int[] numbers = new int[10001];
            // Generer tilfældige tal til array
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-100, 101);    
            }

            // Gennemsnits værdi af array
            double avg = numbers.Average();
            // max værdi af array
            double maxValue = numbers.Max();
            // Minimums værdi af array
            double minValue = numbers.Min();

            // Få max ved hjælp af loop
            int max = Int32.MinValue;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            //Console.WriteLine(max);
            // Få minimun ved hjælp af loop
            int min = Int32.MaxValue;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                Console.Write(numbers[i] + " ");
            }
            //Console.WriteLine(min);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Gennemnsittet er: " + avg);
            Console.WriteLine("Højeste værdi er: " + maxValue);
            Console.WriteLine("Minimums værdi er: " + minValue);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(numbers.Length);
        }
    }
}