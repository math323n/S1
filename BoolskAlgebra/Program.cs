using System;
using System.Collections.Generic;
using System.Linq;

namespace BoolskAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);
           

            Console.WriteLine("Indtast noget");
            string userInput = Console.ReadLine();
            double.TryParse(userInput, out double numberUser);

          

            if (-10 >= numberUser)
            {
                Console.WriteLine("autist");
            }
            
        }
    }
}
