using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{
    public static class Statements
    {

        public static void BranchingIf()
        {
            int a = 15; //Try changing this later. . .

            if (a < 4) //Few things in c# without a ; at the end 
            {
                Console.WriteLine("Number is less than 4");
                Console.WriteLine("more stuff. . .");
            }
            else if (a >= 4 && a <= 10)
            {
                Console.WriteLine("Number is between 4 and 10 (inclusive)");
            }
            else
            {
                Console.WriteLine("Number is greater than 10");
            }

            //One Line Test. . . .
            int b = 10;
            if (b > 5)
                Console.WriteLine("B is bigger than 5");
        }

        public static void Switching()
        {
            int d = 365;
            string day = "";

            switch (d % 7) //No ; after starting a switch (using %7 to wrap days in weeks)
            {
                case 1: //In case d == 1
                    day = "Monday";
                    break;
                case 2: //In case d == 2
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Weekend!";
                    break;
            }
            Console.WriteLine("Day {0} is {1}", d, day);
        }

        public static void ForLoop()
        {
            //Used for counting (often with integers)
            // for (intilializer; test-expression; updater)
            for (int i =0; i < 15; i++) //no ; here
            {
                Console.WriteLine("The Value of i is {0}", i);
            }

            //Nested For Loops Useful for populating or traversing a grid 
            //outer loop (i)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ouer Loop {0}", i);
                //inner loop j
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tInner Loop {0}");
                }



            }
        }

        public static void WhileLoops()
        {
            //while (test-expression == true) { statement }
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }

            //do-while loop  TESTING gets done at the END (or bottom) of the loop 
            int j = 0;
            do
            {
                Console.WriteLine("The value of i is {0}, i");
                j++;
            }
            while (j < 5);

            //do-whiles are used for accepting input fron a user until they "q"
            do
            {
                Console.Write("Enter Command: >");
            }
            while (Console.ReadLine() != "q");
        }

        public static void LoopingArrays()
        {
            string[] monster = new string[16];
            monster[0] = "Spade Foot Soldier";
            monster[1] = "Heart Foot Soldier";
            monster[2] = "Clover Foot Soldier";
            monster[3] = "Diamond Foot Soldier";
            monster[4] = "The Queen of Hearts";
            monster[5] = "The King of Hearts";
            monster[6] = "Cheshire Cate";
            monster[7] = "Mad Hatter";
            monster[8] = "Mad Rabbit";
            monster[9] = "Mad Mouse";
            monster[10] = "Carpenter";
            monster[11] = "Walrus";
            monster[12] = "The Flock Party";
            monster[13] = "Tweedle Dee";
            monster[14] = "Tweedle Dum";
            monster[15] = "Jabberwock";

            Console.WriteLine("Monster List:");
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("\t{0}", monster[i]);
            }
        }

        public static void ForEachIterations()
        {
            List<string> encounter = new List<string>();
            encounter.Add("Pocket Watch");
            encounter.Add("Drink Labled 'Shrink'");
            encounter.Add("Cake Labled 'Grow'");
            encounter.Add("Baby Clam");
            encounter.Add("Propeller Hat");
            encounter.Add("Red Rose");

            Console.WriteLine("List of Encounter Items in your Blue Dress:");
            //Iterate through them. . .
            foreach( string e in encounter)
            {
                Console.WriteLine("\t{0}", e);
            }
        }
    }
}

