using System;

namespace MetoderOpgave02
{
    class Program
    {
        static void Main()
        {
            PrintMenuHeader("Animals");
            PrintMenuItem("Cow");
            PrintMenuHeader("Countries");
            PrintMenuItems("Tuvalu", "Nauru");
            PrintMenuHeader("Great Leaders");
            PrintMenuItems("Donald Trump", "Vladimir Putin", "kim Jong-un");

        }
        private static void PrintMenuHeader(string text)
        {
            Console.WriteLine("*** " + text + " ***");
        }
        private static void PrintMenuItem(string text)
        {
            Console.WriteLine("1) " + text);
        }
        private static void PrintMenuItems(string text01, string text02)
        {
            Console.WriteLine("1) " + text01);
            Console.WriteLine("2) " + text02);
        }
        private static void PrintMenuItems(string text01, string text02, string text03)
        {
            Console.WriteLine("1) " + text01);
            Console.WriteLine("2) " + text02);
            Console.WriteLine("3) " + text03);
            ;
        }




    }
}
