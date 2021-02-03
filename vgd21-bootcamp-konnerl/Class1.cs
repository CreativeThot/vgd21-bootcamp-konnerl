using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{

    public static class Storing
    {
        //Creat an enum
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        //Structs start here
        struct _enemy
        {
            public string name;
            public int health;
            public bool isAlive;
            public float damage;
        }

        //Our first method
        public static void Initialize()
        {
            Console.WriteLine("HI!");
            Console.WriteLine("C# Bootcamp Initialized.");
        }

        //Our second method
        public static void DemoVariables()
        {
            int health = 5002;
            char firstInitial = 'A';
            float Sanity = 100f;
            bool isAsleep = true;
            string playerFullName = "Alice";

            Console.WriteLine("Health:\t\t" + health);
            Console.WriteLine("Full Name:\t\t{0}  [{1}]", playerFullName, firstInitial);
            Console.WriteLine("Sanity:\t\t{0}\nIs Asleep?:\t\t{1}", Sanity, isAsleep);
        }

        public static void ReadingInput ()
        {
            Console.Write("What is your name? > ");
            string playername = Console.ReadLine();
            Console.WriteLine("Hello, {0}! Welcome to the Wonderland!", playername);
            Console.Write("What is your favorite character in Wonderland? > ");
            string charactername = Console.ReadLine();
            Console.WriteLine("What a fine choice~");

        }

        public static void UsingArrays()
        {
            string[] enemyName = new string[6];
            enemyName[0] = "a Spade Foot Soldier";
            enemyName[1] = "a Heart Foot Soldier";
            enemyName[2] = "a Clover Foot Soldier";
            enemyName[3] = "a Diamond Foot Soldier";
            enemyName[4] = "the Queen of Hearts";
            enemyName[5] = "the King of Hearts";
            int[] enemyHealth = new int[6] { 25, 25, 25, 25, 50, 1};

            System.Random random = new System.Random();
            // while (true) 
            // {
            int num = random.Next(5);
            Console.WriteLine("You encounter {0} in the Card Kingdom. They have {1} health", enemyName[num], enemyHealth[num]);
            enemyHealth[num]--;
            //}   
        }

        public static void ConstantsEnumStruts()
        {
            //Constants
            const double pi = 3.145926535;
            Console.WriteLine(pi);
            //pi = 314; //You cannot change this

            //Enums short for "enumerators"
            var dayOfWeek = Days.Sunday;
            Console.WriteLine("The day of the week is {0}", dayOfWeek);
            if (dayOfWeek == Days.Saturday || dayOfWeek == Days.Sunday)
            {
                Console.WriteLine("It's the weekend . . . yay!");
            }else
            {
                Console.WriteLine("It's a work day . . . bummer~");
            }

            //Structs 
            _enemy TheUnknown;
            TheUnknown.name = "The Jester";
            TheUnknown.health = 120;
            TheUnknown.isAlive = true;
            TheUnknown.damage = 5.4f;

            TheUnknown.health--;
            Console.WriteLine("{0} has health of {1} ", TheUnknown.name, TheUnknown.health);
        }

    }//public static class Storing
}

