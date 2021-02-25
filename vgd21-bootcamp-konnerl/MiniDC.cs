using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_konnerl
{
    public static class MiniDC
    {
        struct _player //Willf inlcude monsters
        {
            public int ID; // 0 will be you
            public string name;
            public int health;
        };

        struct _location
        {
            public string locationName;
            public string description;
            public int monsterID; //Can add more (treasure, end-condition, healing)
        };

        public static void PlayGame()
        {

            string version = "0.0.1"; //Base model

            //Create player
            _player player;
            player.ID = 0;
            Console.Write("What is your player's name?: >");
            player.name = Console.ReadLine();
            player.health = 100;

            //Start the player at 5,5
            int pX = 5;
            int pY = 5;


            //Create a few monsters. . . 
            _player[] monster = new _player[12];

            //Player[0] is you
            monster[1].ID = 1; monster[1].name = "Queen of Hearts"; monster[1].health = 110;
            monster[2].ID = 2; monster[2].name = "White Rabbit"; monster[2].health = 5;
            monster[3].ID = 3; monster[3].name = "Gorey Gryphon"; monster[3].health = 65;
            monster[4].ID = 4; monster[4].name = "Broken Maid"; monster[4].health = 35;
            monster[5].ID = 5; monster[5].name = "Narsissistic Caterpiller"; monster[5].health = 40;
            monster[6].ID = 6; monster[6].name = "Abandonded Pup"; monster[6].health = 250;
            monster[7].ID = 7; monster[7].name = "The Insane Hatter"; monster[7].health = 78;
            monster[8].ID = 8; monster[8].name = "Cheshire Cat"; monster[8].health = 15;
            monster[9].ID = 9; monster[9].name = "Aggravated Carpenter"; monster[9].health = 30;
            monster[10].ID = 10; monster[10].name = "Nameless Twin"; monster[10].health = 34;

            //Create new locations
            int maxX = 10;
            int maxY = 10;

            _location[,] location = new _location[maxX, maxY];
            location[5, 5].locationName = "Flower Field";
            location[5, 5].description = "A variety of techno-color flowers almost obscere your view, where is that darn rabbit?!.";
            location[4, 7].locationName = "Mushroom Stomp";
            location[4, 7].description = "A smoking caterpiller, with features that define him as an old man, sits on a huge mushroom, puffing out shapes and letters every now and then. His attention turns towards you as he puffs a smoke cloud in your face with a smug grin";
            location[4, 7].monsterID = 5;
            location[5, 0].locationName = "Card Kingdom";
            location[5, 0].description = "A kingdom made, almost, completely out of cards with the citizens either wearing cards or eighteenth century clothing. Red roses and white-red painted roses populate the area. The Queen steps from her throne and challenges you to a duel.";
            location[5, 0].monsterID = 1;
            location[9, 3].locationName = "Cliff Face";
            location[9, 3].description = "A cliff looms over your person, you barley see two creatures on top of the cliff. You realize a gryphon is tearing into a mock turtle, chunks of meat in it's pouring out of it's mouth. It then looks your direction and swoops in for the kill!";
            location[9, 3].monsterID = 3;
            location[3, 8].locationName = "Duchess's Cabin";
            location[3, 8].description = "You enter the seemingly comfy looking cabin and enter seeing a maid overlooking a boiling pot with a single arm sticking out, she turns towards you with a wicked smile saying 'Care to join my mistress young one?'";
            location[3, 8].monsterID = 4;
            location[0, 0].locationName = "Edge of the Beach";
            location[0, 0].description = "You find yourself on a beach front filled to the brim of empty calm shells and find a man in blue overalls and red hair breathing heavily with hammer in hand. He turns towards you yelling that 'He won't be anyone's worker NO MORE!' and charges at you.";
            location[0, 0].monsterID = 9;
            location[0, 4].locationName = "Desolate Forest";
            location[0, 4].description = "You stumble your way into a dark and bleek forest seeing a lone person with a saddened expression holding onto a whirly hat. He doesn't say a word but their deamonor expresses he doesn't want to fight, you go and fix that~";
            location[0, 4].monsterID = 10;
            location[1, 6].locationName = "White Rabbits Abode";
            location[1, 6].description = "You find what seems to be the rabbits home, nothing of importance seems to be in here.";
            location[1, 7].locationName = "Beside the White Rabbit's Abode";
            location[1, 7].description = "You go beside the rabbits house and discover a chained up giant dog, it sees you and foams at the mouth each second it trys to tug it's way towrads you till the chain is broken and it punces at you";
            location[1, 7].monsterID = 6;
            location[5, 3].description = "You run into that dammed rabbit still yelling that he's late and he must hurry, you decided to take care of him.";
            location[5, 3].monsterID = 2;
            location[9, 7].locationName = "Insane Hatter's Tea Party";
            location[9, 7].description = "You find yourself attending to the Insane Hatter's Tea Party where his friends the March Hare and the Door Mouse are next to him unmoving, he looks towards you and wickedly smiles as he ask's 'Care to join?'";
            location[9, 7].monsterID = 7;
            location[7, 9].description = "You've come across the Cheshire Cat bearing that same irrittating smile, you had enough of his tricks and decide to take acre of them";
            location[7, 9].monsterID = 8;

            //Start the game engine
            Console.WriteLine("Welcome to Wonderland~ (Version {0})");
            Random dice = new Random();
            while (true) //Forever Loop
            {
                //Display Location
                Console.WriteLine("\n\n------------------------------------------------------");
                Console.WriteLine("Your health is: {0}", player.health);
                Console.WriteLine("Your location: ({0},{1}  **{2}**", pX, pY, location[pX, pY].locationName);
                Console.WriteLine(location[pX, pY].description);

                //Monster Detection & Battle
                if (location[pX, pY].monsterID != 0)
                {
                    int mID = location[pX, pY].monsterID;
                    Console.WriteLine("You encounter {0} with {1} health", monster[mID].name, monster[mID].health);

                    //Battle
                    int damageToMonster = dice.Next(0, 20);
                    int damageToPlayer = dice.Next(0, 20);

                    player.health -= damageToPlayer;
                    monster[mID].health -= damageToMonster;

                    Console.WriteLine("You take {0} damage.", damageToPlayer);
                    Console.WriteLine("{0} takes {1} damage.", monster[mID].name, damageToMonster);
                    Console.WriteLine("Your health is {0}. Monster's health is {1}\n", player.health, monster[mID].health);

                    //Deal with death
                    if (monster[mID].health <= 0)
                    {
                        Console.WriteLine("You killed {0}.", monster[mID].name);
                        location[pX, pY].monsterID = 0; //Remove them from game 
                    }

                    if (player.health <= 0)
                    {
                        Console.WriteLine("Sorry to cut this short but, {0} it's time to leave.", player.name);
                        return;
                    }

                } //Done with monsters

                //Special Rooms
                if(pX == 3 && pY == 9)
                {
                    Console.WriteLine("You find some porckchops laid out on a decroctive plate on the ground, you decide to eat not wanting the food to be spoiled.");
                    player.health += 15;
                }

                if (pX == 5 && pY == 5)
                {
                    Console.WriteLine("You discover a fan and a pair of gloves, you slip the glove on and its fits . . . like a glove and tuck the knife away.");
                }

                if (pX == 2 && pY == 3)
                {
                    Console.WriteLine("You find a bottle labled 'Drink Me' you proceed to drink it and you shrink down to microscopic size but return to noraml after a few seconds and feel refreshed!");
                    player.health += 20;
                }

                if (pX == 7 && pY == 6)
                {
                    Console.WriteLine("You find a piece of cake on the ground and decide to eat it since it looks appetzing but as soon as you take a single bite and begin to grow large! Though sadly you return to normal after a few minutes but feel re-invigorated");
                    player.health += 17;
                }

                if (pX == 1 && pY == 6)
                {
                    Console.WriteLine("You journey further into the house anyway and find a quiant little tea set on a decrotive table, you take the oppurtunity to rest and have a drink");
                    player.health += 25;
                }

                //Ask the player for command. . .
                Console.Write("\nYour wish is my command: >");
                string cmd = Console.ReadLine();
                if (cmd == "q")
                {
                    Console.WriteLine("Thank you for playing");
                    return;
                }
                if (cmd == "n") pY--;
                if (cmd == "e") pX++;
                if (cmd == "s") pY++;
                if (cmd == "w") pX--;
                if (pX < 0) pX = 0;
                if (pX > maxX) pX = maxX;
                if (cmd == "m") DrawMap(location, pX, pY);
                pX = Math.Clamp(pX, 0, maxX - 1);
                pY = Math.Clamp(pY, 0, maxY - 1);


            } //end of while true
        }

        private static void DrawMap(_location[,] loc, int playerX, int playerY)
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.array.length?view=net-5.0
            //Console.WriteLine(loc.Rank);
            int xDim = loc.GetUpperBound(0);
            int yDim = loc.GetUpperBound(1);
            //Console.WriteLine("{0}, {1}", xDim, yDim);
            for (int y = 0; y <= yDim; y++)
            {
                for (int x = 0; x <= xDim; x++)
                {
                    string locName = "*";

                    if (loc[x, y].locationName != null || loc[x, y].monsterID != 0)
                    {
                        //locName = (loc[x, y].locationName).Substring(1,1);
                        locName = "+";
                    }
                    if (x == playerX && y == playerY)
                    {
                        locName = "X";
                    }
                    Console.Write(locName);
                }
                Console.WriteLine("");
            }
        }


    }
}
