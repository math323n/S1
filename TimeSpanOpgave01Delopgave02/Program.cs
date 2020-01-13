using System;
using System.Globalization;

namespace TimeSpanOpgave01Delopgave02
{
    class Program
    {
        static void Main()
        {
            // Kultur info
            CultureInfo[] cultures = { new CultureInfo("da-DK") };
            // tid indtil juleaften
            DateTime christmas = new DateTime(2019, 12, 24);
            TimeSpan timeUntilChristmas = DateTime.Now - christmas;

            // Tid indtil nytår
            DateTime newYear = new DateTime(2020,01,01);
            TimeSpan timeUntilNewYear = DateTime.Now - newYear;

            // Tid siden fødselsdag
            DateTime birthdate = new DateTime(2001, 10, 24);
            TimeSpan timeSinceBirthdate = DateTime.Now - birthdate;

            // Tid siden dronning Magrethe II blev kronet
            DateTime magrethe = new DateTime(1972, 1, 14);
            TimeSpan TimeSinceMagrethe = DateTime.Now - magrethe;

            // Tid til næste tv-avis
            DateTime tvNews = new DateTime(2019, 12, 14, 18, 30, 00);
            TimeSpan timeUntilNews = DateTime.Now - tvNews;

            // Udskriv tid indtil juleaften
            Console.WriteLine("Tid indtil juleaften: " +
                string.Format("{0:dd\\:hh\\:mm\\:ss}", timeUntilChristmas));
            // Udskriv tid indtil nytår
            Console.WriteLine("Tid indtil nytår: " +
                string.Format("{0:dd\\:hh\\:mm\\:ss}", timeUntilNewYear, cultures[0]));
            // Udskriv tid side fødselsdag
            Console.WriteLine("Tid siden fødselsdag: " +
                string.Format("{0:dd\\:hh\\:mm\\:ss}", timeSinceBirthdate, cultures[0]));
            // Udskriv tid siden magrethes kroning
            Console.WriteLine("Tid siden dronning magrethes 2 kroning: " +
                string.Format("{0:dd\\:hh\\:mm\\:ss}", TimeSinceMagrethe, cultures[0]));
            // Udskriv tid indtil tv-avisen på lørdag 
            Console.WriteLine("Tid indtil næste tv-avis: " +
                string.Format("{0:dd\\:hh\\:mm\\:ss}", timeUntilNews, cultures[0]));


        }
    }
}