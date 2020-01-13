using System;

namespace DateTimeOpgave03Delopgave03
{
    class Program
    {
        static void Main()
        {
            DateTime currentYear = DateTime.Now;
            Console.Write("Indtast din alder: ");
            string userbirthdate = Console.ReadLine();
            int birthdateTime = int.Parse(userbirthdate);

            DateTime time = currentYear.AddYears(-birthdateTime);
            Console.WriteLine(time);
            if(birthdateTime >= 18)
            {
                Console.WriteLine("Du må købe spiritus, og få kørekort, og drikke øl");
            }
            else if(birthdateTime >= 17)
            {
                Console.WriteLine("Du må få kørekort og drikke øl");
            }
            else if(birthdateTime >= 16)
            {
                Console.WriteLine("Du må drikke øl");
            }
        }
    }
}
