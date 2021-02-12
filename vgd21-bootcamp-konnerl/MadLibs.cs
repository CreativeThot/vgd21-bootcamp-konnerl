using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{
    class MadLibs
    {
        public static class MadLib
        {

            public static void Execute()
            {
                Console.Write("Adjective, please: >");
                string adj1 = Console.ReadLine();
                Console.Write("Nationality, please: > ");
                string nation1 = Console.ReadLine();
                Console.Write("Person, please: >");
                string per1 = Console.ReadLine();
                Console.Write("Noun, please: >");
                string noun1 = Console.ReadLine();
                Console.Write("Adjective, please: >");
                string adj2 = Console.ReadLine();
                Console.Write("Noun, please: >");
                string noun2 = Console.ReadLine();
                Console.Write("Adjective, please: >");
                string adj3 = Console.ReadLine();
                Console.Write("Adjective, please: >");
                string adj4 = Console.ReadLine();
                Console.Write("Plural Noun, please: >");
                string pnoun1 = Console.ReadLine();
                Console.Write("Noun, please: >");
                string noun3 = Console.ReadLine();
                Console.Write("Number, please: >");
                string num1 = Console.ReadLine();
                Console.Write("Shapes, please: >");
                string shape1 = Console.ReadLine();
                Console.Write("Food, please: >");
                string food1 = Console.ReadLine();
                Console.Write("Food, please: >");
                string food2 = Console.ReadLine();
                Console.Write("Number, please: >");
                string num2 = Console.ReadLine();


                Console.WriteLine("---------------------\n\n");
                Console.WriteLine("Pizza was invented by {0} {1} chef named {2}.", adj1, nation1, per1);
                Console.WriteLine("To make pizza, you need to take a lump of {0}, and make a thin, round {1} {2}.", noun1, adj2, noun2);
                Console.WriteLine("Then you cover it with {0} sauce, {1} cheese, and fresh chopped {3}.", adj3, adj4, pnoun1);
                Console.WriteLine("Next you have to bake it in a very hot {0}", noun3);
                Console.WriteLine("When it is done, cut it into {0} {1}.", num1, shape1);
                Console.WriteLine("Some kids like {0} pizza the best, but my favorite is the {1} pizza.", food1, food2);
                Console.WriteLine("If I could, I would eat pizza {0} times a day", num2);

            }
        }

    
    }
}
