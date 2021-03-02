using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{
    public static class ErrorTrapping
    {
        public static void DontCatchRunTime()
        {

            Console.WriteLine("The divideer by zero error. . .");
            int numerator = 10;

            for (int x = -3; x <= 3; x++)
            {

                int answer = numerator / x;
                Console.WriteLine("{0}/{1} = {2}");
            }
        }

        public static void CatchRunTime()
        {

            try
            { //Try running this code. . .
                Console.WriteLine("The divider by zero error. . .");
                int numerator = 10;
                for (int x =-3; x <= 3; x++)
                {
                    int answer = numerator / x;
                    Console.WriteLine("{0}/{1} = {2}", numerator, x, answer);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("We caught the error!");
                Console.WriteLine(error.Message);
                Console.WriteLine(". . . continue forawrd in your dream land~");
            }
        }
    }
}
