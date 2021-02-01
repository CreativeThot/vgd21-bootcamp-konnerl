using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{
    public static class Storing
    {

        //Our first method
        public static void Initialize()
        {
            Console.WriteLine("HI!");
            Console.WriteLine("C# Bootcamp Initialized.");
        }

        //Our second method
        public static void DemoVariables()
        {
            int employeeID = 5002;
            char firstInitial = 'K';
            float bodyTemp = 98.4f;
            bool isAlive = true;
            string employyeFullName = "Konner Lewis";

            Console.WriteLine("Enployee ID:\t\t" + employeeID);
            Console.WriteLine("Full Name:\t\t{0}  [{1}]", employyeFullName, firstInitial);
            Console.WriteLine("Body Temp:\t\t{0}\nIs ALive?:\t\t{1}", bodyTemp, isAlive);
        }

        public static void ReadingInput ()
        {
            Console.Write("What is your name? > ");
            string playername = Console.ReadLine();
            Console.WriteLine("Hello, {0}! Welcome to the Dungeon!!!", playername);
            Console.Write("How old are you (in years? > ");
            int ageInYears = Convert.ToInt16(Console.ReadLine());
            int months = ageInYears * 12;
            float days = ageInYears * 365.25f;
            Console.WriteLine("You are {0} months old. You are {1} days old", months, days);

        }

        public static void UsingArrays()
        {
            string[] enemyName = new string[5];
            enemyName[0] = "Evan the Evil";
            enemyName[1] = "Katelehn the Killer";
            enemyName[2] = "Sawyer the Slasher";
            enemyName[3] = "Cody the Crusher";
            enemyName[4] = "Jim the Jester";

            System.Random random = new System.Random();
            // while (true) 
               // {
                int num = random.Next(5);
                Console.WriteLine("You encounter {0} in a dark dungeon.", enemyName[num]);
            //}   
          }  

    }//public static class Storing
}

