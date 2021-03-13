using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{
    public static class StringWork
    {
        public static void ManipulatingStrings()
        {
            Console.WriteLine("Q1: Enter Your Name: >\n");
            string text = Console.ReadLine();
            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("\n Error Does Not Contian Name: >");
            }
            else
            {
                Console.WriteLine("\nThanks! You entered '{0}'", text);
                text = text.Trim();
            }
       
        }

        public static void StringFeatures()
        {
            Console.WriteLine("Q2: Enter a Name with a Z: >\n");
            string text = Console.ReadLine();
            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("\nError: Doesn't Contain a Name");
            }
            else
            {
                Console.WriteLine("Thanks. You entered: \n'{0}'\n", text);
                string query = text.StartsWith("Z") ? "Does" : "Does Not";
                Console.WriteLine("Text " + query + " start with 'Z'");
            }

        }

        public static void StringSplit()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            Console.WriteLine("Q3: Enter a list of weapons by comma: >");
            string text = Console.ReadLine();
            System.Console.WriteLine($"Original text: '{text}'");

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine($"{words.Length} words in text:");

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }
        }

        public static void DateStrings()
        {

            Console.WriteLine("Q4: Enter year of bith: >");
            Console.ReadLine();
            Console.WriteLine("Enter month of birth: >");
            Console.ReadLine();
            Console.WriteLine("Enter day of birth: >");
            Console.ReadLine();

            //Make your own...
            DateTime birthday = new DateTime(2256, 12, 10);
            Console.WriteLine(birthday.DayOfWeek);
            //Can also use the {} syntax:
            Console.WriteLine("Birthday is on a {0:dddd}", birthday);
            //Other options include {0:D}, {0:T}, {0:M}, {0:YYYY}, {0:HH}, etc...
        }

        public static void OneCAtATime()
        {
            Console.WriteLine("Q5: Enter a world name: > ");
            string text = Console.ReadLine();
            string a = "abcdefghijklmnopqrstuvwxyz";
            for (int m = 0; m < a.Length; m++)
            {
                string letter = a.Substring(m, 2);
                Console.WriteLine(letter);
            }
        }

    }
}
