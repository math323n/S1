using System;
using System.Collections.Generic;

namespace OOPObjekterOpgave01
{
    class Program
    {
        // List of cars
        public static List<CarHandler.Car> listOfCars = new List<CarHandler.Car>();

        static void Main()
        {
            // Add 3 cars
            CarHandler.Car car1 = new CarHandler.Car("Ford", "Mustang", 2018, "Blå");
            CarHandler.Car car2 = new CarHandler.Car("Toyota", "Hilux", 2019, "Rød");
            CarHandler.Car car3 = new CarHandler.Car("Honda", "Jazz", 2019, "Sort");
            listOfCars.Add(car1);
            listOfCars.Add(car2);
            listOfCars.Add(car3);

            PrintMenu();
        }

        // Create the menu
        static void PrintMenu()
        {
            Console.WriteLine(
           "Hej og velkommen til biladministrationen version 1997\n" +
           "Du har nu to muligheder. Ønsker du at:\n" +
           "Indtaste en bil (1)?\n" +
           "Se informationer om alle biler (2)?\n" +
           "Søg efter bil (3)?");
            Console.Write("Indtast dit ønske: ");

            // Get user input
            string userInputString = Console.ReadLine();
            if(userInputString == "1")
            {
                CreateCar();
            }
            else if(userInputString == "2")
            {
                PrintInformation();
            }
            else if(userInputString == "3")
            {
                SearchForCar();
            }
        }

        // Create car
        private static void CreateCar()
        {
            bool loopDone = false;
            while(!loopDone)
            {
                Console.WriteLine("Du ønsker at oprette en bil.");
                // Get brand of car
                Console.Write("Indtast mærke: ");
                string carBrand = Console.ReadLine();
                // Get model of car
                Console.Write("Indtast model: ");
                string carModel = Console.ReadLine();
                // Get year of car (MUST be after car was invented AND NOT after current year.
                Console.Write("Indtast årgang: ");
                string carYearString = Console.ReadLine();

                // Parse carYearString into an int, if failed, ask for input again.
                int carYearInt;
                while(!Int32.TryParse(carYearString, out carYearInt))
                {
                    Console.WriteLine("Fejl, kun tal kan modtages.");
                    Console.Write("Indtast årgang: ");
                    carYearString = Console.ReadLine();
                }
                Console.Write("Indtast farve: ");
                string carColor = Console.ReadLine();

                // Create instance of Car
                CarHandler.Car car = default;
                // Try catch for incorrect year
                try
                {
                    // Use input variables as properties of new car.
                    car = new CarHandler.Car(carBrand, carModel, carYearInt, carColor);
                }
                catch(ArgumentOutOfRangeException)
                {
                    // Error message for user and restart method
                    Console.WriteLine("FEJL: Året er før bilen er opfundet.\nEller året er i fremtiden.");
                    CreateCar();
                }
                // Test for engine ignition, return boolean.
                // If engine ignition works
                if(car.StartCar() == true)
                {
                    Console.WriteLine($"{car} brugte 1 forsøg på at starte.");
                }
                // Else if engine ignition fails.
                else if(car.StartCar() == false)
                {
                    Console.WriteLine($"{car} kunne ikke starte.");
                }

                // Add car to list
                listOfCars.Add(car);
                Console.WriteLine("Du har nu oprettet en bil, tast 1 for at afslutte eller 2 for at lave en ny.");
                // Let user choose next action for program
                string userChoice = Console.ReadLine();
                // Return to menu
                if(userChoice == "1")
                {
                    Console.Clear();
                    Main();
                }
                // Create a new car
                else if(userChoice == "2")
                {
                    Console.Clear();
                    CreateCar();
                }
            }
        }

        // Print information about car method
        private static void PrintInformation()
        {
            foreach(CarHandler.Car car in listOfCars)
            {
                Console.WriteLine(car.ToString());
            }
            PrintMenu();
        }

        // Search for car
        private static void SearchForCar()
        {
            Console.Write("Søg på en bil: ");
            // Get user input
            string userInput = Console.ReadLine().ToLower();
            foreach(CarHandler.Car car in listOfCars)
            {
                if(userInput == car.Make.ToLower())
                {
                    // Print information on car
                    Console.WriteLine(car);
                    // It just works ¯\_(ツ)_/¯
                }
            }
        }
        
    }
}
