using System;
using System.Collections.Generic;
using System.Linq;

namespace StarTrekProgram
{
    class Program
    {
        // Fields
        static List<string> vulcanMaleNames = new List<string>();
        static List<string> vulcanFemaleNames = new List<string>();
        static string[] maleVulcanValidCharacters = { "S,Sp,Sk,St,T", "a,e,i,o,u,y", "r,t,p,d,f,j,k,l,v,b,n,m", "a,e,i,o,u,y", "q,p,k,ck,l" };
        static string[] femaleVulcanValidCharacters = { "T'", "P,K,Q", "a,e,i,o,u,y", "r,j,'p,k,l" };
        static int maleNameCount;
        static int femaleNameCount;

        // Methods
        static void Main()
        {
            GenerateNames();
           

        }
        static bool IsNameValid(string name)
        {
            return true;
        }
        static void GenerateNames()
        {


            for(int i = 0; i < 10343804440; i++)
            {
                // Get first name
                string[] maleVulcanFirstName = maleVulcanValidCharacters[0].Split(",");

                Random random = new Random();
                int index = random.Next(maleVulcanFirstName.Length);
                // First name of vulcan
                Console.Write(maleVulcanFirstName[index]);

                // Get second name
                string[] maleVulcanSecondName = maleVulcanValidCharacters[1].Split(",");
                random = new Random();
                index = random.Next(maleVulcanSecondName.Length);
                // Second name of vulcan
                Console.Write(maleVulcanSecondName[index]);

                // Get third name   
                string[] maleVulcanThirdName = maleVulcanValidCharacters[2].Split(",");
                random = new Random();
                index = random.Next(maleVulcanSecondName.Length);
                // Third name of vulcan
                Console.Write(maleVulcanThirdName[index]);

                // Get fourth name
                string[] maleVulcanFourthName = maleVulcanValidCharacters[1].Split(",");
                random = new Random();
                index = random.Next(maleVulcanFourthName.Length);
                // Second name of vulcan
                Console.Write(maleVulcanFourthName[index]);

                // Get fifth name
                string[] maleVulcanFifthName = maleVulcanValidCharacters[1].Split(",");
                random = new Random();
                index = random.Next(maleVulcanFifthName.Length);
                // Second name of vulcan
                Console.Write(maleVulcanFifthName[index] + "\n");
                string completeName = $"{maleVulcanFirstName}{maleVulcanSecondName}{maleVulcanThirdName}"
                    + $"{maleVulcanFourthName}{ maleVulcanFifthName}";
                vulcanMaleNames.Add(completeName);

            }
        }
        static void GetUserInput()
        {
            Console.WriteLine("Hvor mange Vulcan hannavne vil du have?");
            string firstUserInput = Console.ReadLine();
            if(int.TryParse(firstUserInput, out int number))
            {
                maleNameCount = number;
            }
            else
            {
                Console.WriteLine("Fejl, du indtastede ikke et gyldigt tal.");
            }

        }
      



    }
}