using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{
    public static class Operations
    {


        //Method. . .
        public static void Arithmetic()
        {
            //Use the debugger to watch the changes. . .
            int a = 9;
            int b = 6;
            int c;

            a++; //Incroment
            b--; //Decroment

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            c = a % b; //Module operator. . .a/b then return the remainder (10/5)=2R0
            c = b % a; //(5/10)=0R5
            c = 13 % 2; //(13/2) = 6R1
            c = 14 % 2; //(14/2) = 7R0
            c = 15 % 2; // (15/2) = 7R1 //Used to see if a number is odd or evem

            //Assignement
            a += b; // Before (a = 10, b = 5) . . . after a = 15
            a += 7; // Before (a = 15) . . . after a = 8
            a += b; // Before (a = 8) . . . after a = 40
            a /= 7; // Before (a = 40) . . . after a = 5 (truncates)
        }

        public static void Comparison()
        {
            int a = 10;
            int b = 45;
            int c = 10;
            Console.WriteLine(a == b); // a = b is a mistake 
            Console.WriteLine(a == c);
            Console.WriteLine(a != b);
            Console.WriteLine(a > c);
            Console.WriteLine(a >= c);
            Console.WriteLine(a < c);
            Console.WriteLine(a <= c);
        }

        public static void Logic()
        {
            int playerXP = 80;
            int playerHealth = 15;
            bool hasWeapon = true;
            bool hasMagic = false;

            bool canEnterRealWorld = false;

            //AND . . . where all items must be true &&
            canEnterRealWorld = (playerXP > 70 && playerHealth >= 10 && hasMagic);
            Console.WriteLine("Can you catch the rabbit?" + canEnterRealWorld);

            //OR . . . where any one item can be true ||
            bool canDrinkBottle = false;
            canDrinkBottle = (hasMagic || !hasWeapon); //! = not
            Console.WriteLine("Can drink the bottle?" + canDrinkBottle);

            //XOR . . . Exclusive OR ONLY ONE can be true (TT won't work, TF will work, FT will work, FF won't work)
            //  Use the ^ symbol
        }

            public static void Ternary()
            {
                int a, b, c;
                a = 16;
                b = 69;
                c = (a == b) ? a : b; //Ternary Operator
                // (test) ? (if test is true) : (if test is false)
                Console.WriteLine(c);

                //Equivalent Code:
                if (a ==b)
            {
                c = a;
            }
            else
            {
                c = b;
            }

             }
    }
}
