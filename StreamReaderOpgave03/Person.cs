using System;
using System.Collections.Generic;
using System.Text;

namespace StreamReaderOpgave03
{
    class Person
    {
        // Fields
        private string firstName;
        private string lastName;
        private int age;

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }

        // Properties
        // First name
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        // Last name
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        // Age
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }


        // Metoder
        public static void PrintPersonInformation(Person person)
        {
            Console.WriteLine();
        }



    }
}
