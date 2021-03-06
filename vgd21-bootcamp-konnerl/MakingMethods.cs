using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{
    public static class MakingMethods
    {
        //Methods are created like this:

        // access-type return-data-type method-name ( parameters ) { your code } 

        //Access-type: public, private, protected*, internal*
        //Data-type: string, int, float, bool, double, objects

        private static double BodyTempF()
        {
            double temperture = 98.99999;
            return temperture;

        }

        private static double BodyTempC()
        {
            return 37.0;
        }

        public static void ReportBodyTemp()
        {
            double btF = BodyTempF();
            double btC = BodyTempC();
            Console.WriteLine("Your temp is {0} degF or {1} degC.", btF, btC);

        }

        //How to use arguements
        public static double ConvertFtoC (double degF)
        {
            double C;
            C = (degF - 32.0) * 5.0 / 9.0;
            return C;
        }

        //Overloading: same method name, but different arguements, different return types
        public static float Area(float raidus)
        {
            return (3.14159f * raidus * raidus);
        }

        public static float Area(float width, float height)
        {
            return (width * height);
        }

        public static int Area(int edgeOfSquareLength)
        {
            return edgeOfSquareLength * edgeOfSquareLength;
        }

        //Passing values by values or by ref . . . C and C++ but C# can also do it this way . . . 
        //Totally optional . . . be aware of!
        private static int ReturnByValue(int x)
        {
            x++;
            return x * x;
        }

        private static int ReturnByRefrence(ref int x) //Similar to a pointer in C and C#
        {
            x++;
            return x * x;
        }

        public static void TestThem()
        {
            int side = 10;
            int answer;

            answer = ReturnByValue(side);
            Console.WriteLine("When the number of tea is {0}, then the number of hatter's are {1}", side, answer);

            answer = ReturnByRefrence(ref side);
            Console.WriteLine("When the number of tea is {0}, then the number of hatter's are {1}", side, answer);

        }
    }
}
