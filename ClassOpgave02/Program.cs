using System;

namespace ClassOpgave02
{
    class Program
    {
        static void Main()
        {
            // Lav dacia objekt (bil #1)
            Car dacia = new Car("Dacia", "Logan", "Beige", 170000, false);
            // Lav toyota objekt (bil #2)
            Car toyota = new Car("Toyota", "Yaris", "Rød", 89000, true);
            // Lav honda objekt (bil #3)
            Car honda = new Car("Honda", "Civic Type R", "Hvid", 199000, true);

            honda.PutOnSale();
            honda.PrintInfo();
    }
    }
}
