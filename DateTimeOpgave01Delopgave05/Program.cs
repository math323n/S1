using System;

namespace DateTimeOpgave01Delopgave05
{
    class Program
    {
        static void Main()
        {
            string birthdate = "2001-10-24";
            string magrethe = "1940-4-16";
            string constitution = "1849-5-25";
            string handball = "2019-1-10";
            string aspit = "2011-12-20";
            string social = "2019-11-22";
            string arrive = "2019-12-6 08:30";
            string newsLastSat = "2019-11-30";
            
            DateTime myBirthdate = DateTime.Parse(birthdate);
            DateTime magrethesBirthdate = DateTime.Parse(magrethe);
            DateTime constitutionDate = DateTime.Parse(constitution);
            DateTime handballDate = DateTime.Parse(handball);
            DateTime aspitEndTime = DateTime.Parse(aspit);
            DateTime socialAct = DateTime.Parse(social);
            DateTime myArrive = DateTime.Parse(arrive);
            DateTime news = DateTime.Parse(newsLastSat);
            DateTime Now = DateTime.Now;
            DateTime alsoNow = DateTime.Now;



        }
    }
}
