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
            a += b; // Before ( a = 8) . . . after a = 40
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

    }
}
