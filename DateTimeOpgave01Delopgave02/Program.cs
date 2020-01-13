using System;


namespace DateTimeOpgave01Delopgave02
{
    class Program
    {
        static void Main()
        {
            DateTime myBirthdate = new DateTime(2001, 10, 24);
            DateTime magrethesBirthdate = new DateTime(1940, 4, 16);
            DateTime constitutionDate = new DateTime(1849, 5, 25);
            DateTime handballDate = new DateTime(2019, 1, 10);
            DateTime aspitEndTime = new DateTime(2019, 12, 20);
            

            Console.WriteLine(myBirthdate.ToString());
            Console.WriteLine(magrethesBirthdate.ToString());
            Console.WriteLine($"Grundlovsdag: " + constitutionDate.ToLongDateString());
            Console.WriteLine($"Håndbold 2019: " + handballDate.ToShortDateString());
            Console.WriteLine($"Juleafslutning på aspit 2019: " + aspitEndTime.ToString());



        }
    }
}
