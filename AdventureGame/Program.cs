/*
 * [Sci- Fi Effect]
 * by MelissaDTH, 7/2/2020
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System;
using System.Collections.Generic; //gives acces to generic collections

namespace Adventure
{
    public static class Game
    {
        static int Scenarios = 3;
        static string CharacterName;
        static List<string> Inventory = new List<string>();

        static string[] PartOne = {
            // [0]
"You have made enemies and friends in the past, but you don't have to worry about that now. \n First, your adventure has to start.",
            // [1]
            @"
Choose one of the two locations you want to start your adventure:
1. Saturn
                 ,MMM8&&&.
            _...MMMMM88&&&&..._
         .::'''MMMMM88&&&&&&'''::.
        ::     MMMMM88&&&&&&     ::
        '::....MMMMM88&&&&&&....::'
           `''''MMMMM88&&&&''''`
                 'MMM8&&&'

2. Earth
                    _____
                ,-:` \;',`'-, 
              .'-;_,;  ':-;_,'.
             /;   '/    ,  _`.-\
            | '`. (`     /` ` \`|
            |:.  `\`-.   \_   / |
            |     (   `,  .`\ ;'|
             \     | .'     `-'/
              `.   ;/        .'
                `'-._____.

",
            // [2]
@"
Your ship, called the Normandy, is setting course for Saturn.
But while you and your crew are halfway there, something goes wrong...
The Normandy loses fuel and collides into a big space rock!

                 ___---___
              .--         --.
            ./   ()      .-. \.
           /   o    .   (   )  \
          / .            '-'    \         
         | ()    .  O         .  |
        |                         |
        |    o           ()       |
        |       .--.          O   |
         | .   |    |            |
          \    `.__.'    o   .  /    
           \                   /
            `\  o    ()      /'        
              `--___   ___--'
                    ---

",
            // [3]
            @"
You and your crew are staying on Earth in order to keep the peace.
But while you and your crew are sipping (virgin) cocktails in your ship called the Normandy, something goes wrong...
The enemy has found you and is dropping bombs on your location!

             _.-^^---....,,--       
         _--                  --_  
        <                        >)
        |                         | 
         \._                   _./  
            ```--. . , ; .--'''       
                  | |   |             
               .-=||  | |=-.   
               `-=#$%&%$#=-'   
                  | ;  :|     
         _____.,-#%&$@%#&#~,._____

",          // [4]
            "\nYou realize what is happening and you panic for 1.245252 seconds. You then act as \nthe real leader that you are and you know that a though choice has to be made. \n0What will you do? \n \n 1. Be as heroic as you can be \n 2. Save everyone by doing what you do best!",
        // [5]
        @"
You had to make a tough choice and everyone knew it, so their hope on surviving decreased immediatly. You did the best that you could do. 
And that was to do nothing and cower away behind your space cat...
   ,,,,
  /   '
 /.. /
( c  D
 \- '\_
  `-'\)\
     |_ \
     |U \\
    (__,//
    |. \/
    LL__I
     |||
     |||
  ,,-``'\

",
            // [6]
            @"
You had to make a tough choice and everyone knew it, you did the best that you could do. 
And that was to do nothing and watch the world burn, because that's who you are...

   ,,,,
  /   '
 /.. /
( c  D
 \- '\_
  `-'\)\
     |_ \
     |U \\
    (__,//
    |. \/
    LL__I
     |||
     |||
  ,,-``'\

"
        };
        static string[] PartTwo = {
                        // [0]
            "\nAfter hiding for an hour, you find out that everyone in your ship has been killed (see, the crew would 'die' for you). \nYou are able to go to the main deck and you can see on the monitors \nthat your ship is being boarded by enemies. \n\nYou find the following weapons, which one do you choose?\n" +
                "\n1. a blue lightsaber" +
                "\n \n2. a MZ1350 Rocket Launcher",
                        // [1]
            "You turn the lightsaber on and all of a sudden you posses every Force power there is. You move towards the enemy and find yourself in a tough battle. \nIt seems like you've found your inner strength, because you're slaying everyone of them!",
                        // [2]
            "You grab the MZ1350 Rocket Launcher, run towards the breach where the enemy is boarding and start blasting away. \nAll too late you realize that the rocket launcher is doing more damage than good. \nYou win the fight, but have blasted holes into the spacecraft itself!  ",
            "To be continued...",
            // "... part two, again - what happens if A is chosen...",
            // "... part two again - what happens if B is chosen...",
            // "You begin to climb the stairs to the next floor...."
        };
            // ADD LATER
        static string[] PartThree = {
            //"Description of story part three... and the choice A or B",
            //"... part 3 - what happens if A is chosen...",
            //"... part 3 - what happens if B is chosen...",
            //"....more story.... .",
            //"... part 3, again - what happens if A is chosen...",
            //"... part 3 again - what happens if B is chosen...",
            //"You begin to climb the stairs to the next floor...."
        };

        public static void StartGame()
        {
            GameTitle();

            //introduction text
            Console.WriteLine(@"
A great space story awaits you!
You are a space traveler with a crew that will die for you.
You reside on earth, but have a ship to command that can take you anywhere you want...
");

            NameCharacter();
            Choice();
            EndGame();
        }

        public static void EndGame()
        {

            //end of game text
            Console.WriteLine("\n --- THE END ---\n");
            Console.WriteLine("Congratulations " + CharacterName + "!\n");

            Console.WriteLine(CharacterName + " So tell us, how did these decisions work out for you?");

            foreach (string item in Inventory)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
            if (Inventory.Contains("Lightsaber"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n Congratulations on holding a lightsaber though, I'm jealous.");
                Console.ResetColor();
            }
        }
        static void Choice()
        {
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";

                switch (section)
                {
                    case 1:
                        //Part One

                        //same pattern for each of the sections. 1) print the first part of the section
                        Console.WriteLine(PartOne[0]);
                        Console.WriteLine(PartOne[1]);

                        //2)read in player's choice (a or b)
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.Write("Enter your choice (1 or 2): ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        Console.WriteLine("Really? Are you sure about that? Oh well, you can't go back now ha ha. Press enter to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        //3) if saturn: print the next part of the array, otherwise skip next and print 3rd
                        if (input == "1")
                        {
                            Console.WriteLine(PartOne[2]);
                            Inventory.Add("Visited Saturn");

                        }
                        else
                        {
                            Console.WriteLine(PartOne[3]);
                            Inventory.Add("Stayed on Earth");
                        }

                        //4) print next part of the section
                        Console.WriteLine("\n Press enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(PartOne[4]);

                        //5) if 1 print next, otherwise skip ahead
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your choice (1 or 2): ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        Console.WriteLine("Good choice! Press enter to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        if (input == "1")
                        {
                            Console.WriteLine(PartOne[5]);
                            Inventory.Add("Did nothing");

                        }
                        else
                        {
                            Console.WriteLine(PartOne[6]);
                            Inventory.Add("Did nothing");
                        }

                        //6) print last piece of the section
                        // Console.WriteLine("Press enter to continue...");



                        break;

                    case 2:
                        //Part Two

                        Console.WriteLine(PartTwo[0]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your choice please: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        if (input == "1")
                        {
                            Console.WriteLine(PartTwo[1]);
                            Inventory.Add("Lightsaber");
                        }
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                            Inventory.Add("Rocket Launcher");
                        }
                        Console.WriteLine(PartTwo[3]);

                        break;

                    case 3:
                    //Part Three
                    //Console.WriteLine(PartThree[0]);
                    //Console.ForegroundColor = ConsoleColor.Cyan;
                    //Console.Write("Enter your choice: ");
                    //input = Console.ReadLine();
                    //input = input.ToLower();
                    //Console.ResetColor();
                    //if (input == "a")
                    //{
                    //    Console.WriteLine(PartThree[1]);

                    //}
                    //else
                    //{
                    //    Console.WriteLine(PartThree[2]);
                    //}
                    //Console.WriteLine(PartThree[3]);
                    //if (input == "a")
                    //{
                    //    Console.WriteLine(PartThree[4]);

                    //}
                    //else
                    //{
                    //    Console.WriteLine(PartThree[5]);
                    //}
                    //Console.WriteLine(PartThree[6]);
                    //break;

                    default:
                        //default if section number does not match one of the above
                        break;
                }

                //let player advance when ready, then clear the screen
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }
        static void NameCharacter()
        {
            Console.WriteLine("As a space traveler and hero, you need a name. What will it be?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your name: ");

            CharacterName = Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine("Oh... That is what you picked? Okay, " + CharacterName + "... Good luck with that.\n\n");
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        static void GameTitle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //game title
            //game slogan/subtitle
            Console.WriteLine(@"
                                 _______.  ______  __                 _______  __  
                                /       | /      ||  |               |   ____||  | 
                               |   (----`|  ,----'|  |     ______    |  |__   |  | 
                                \   \    |  |     |  |    |______|   |   __|  |  | 
                            .----)   |   |  `----.|  |               |  |     |  | 
                            |_______/     \______||__|               |__|     |__| 
                                                                   
                            _______  _______  _______  _______   ______ .___________.
                           |   ____||   ____||   ____||   ____| /      ||           |
                           |  |__   |  |__   |  |__   |  |__   |  ,----'`---|  |----`
                           |   __|  |   __|  |   __|  |   __|  |  |         |  |     
                           |  |____ |  |     |  |     |  |____ |  `----.    |  |     
                           |_______||__|     |__|     |_______| \______|    |__|
");
            Console.ResetColor();
            Console.WriteLine("*** Press enter to start ***");
            Console.ReadKey();
            Console.Clear();
        }
    }

    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.Read();
        }
    }
}
