/*
 * [Sci - Fi Effect]
 * by MD 't Hart, 06/02/2020
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System; //System is a namespace -> namespace declares a scope that contains a set of related objects. You can use namespace to organize code elements + create globally unique types

namespace Adventure
{

    public static class Game
    {
        // Dialog method
        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }

        static void GameTitle()
        {
            string Title = @"Your title here";
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            Console.Clear();
        }

        public static void StartGame()
        {
            Dialog(@"

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
            NameCharacter();
        }

        public static void ClearConsole()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();
            ClearConsole();
        }

        static void NameCharacter()
        {
            Console.WriteLine(@"
***
What is your hero's name?
");
            string CharacterName = Console.ReadLine();
            Console.WriteLine(@"***
What a poor choice! But you can't go back now, your hero is called: Sad " + CharacterName);
            Console.WriteLine(@"
Press enter to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void OpeningQuestion()
        {
            Console.Title = "Places to go with spacetravel";
            string location;
            Console.Write(@"***
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
");
            location = Console.ReadLine();
            Console.WriteLine(@"
Press enter to continue...");
            Console.ReadKey();
            Console.Clear();

            if (location == "Saturn")
            {
                Console.WriteLine(@"***
Your ship is setting course for Saturn!
But while you're waiting for your ship (the Normandy) to reach lightspeed, something goes wrong...
The Normandy loses fuel and collides into a big space rock.

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
");
                Console.WriteLine(@"
Press enter to continue...");
                Console.ReadKey();
                Console.Clear();

            }
            else if (location == "saturn")
            {
                Console.WriteLine(@"***
Your ship, called, the Normandy, is setting course for Saturn.
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
");
                Console.WriteLine(@"
Press enter to continue...");
                Console.ReadKey();
                Console.Clear();

            }
            if (location == "Earth")
            {
                Console.WriteLine(@"***
Your ship, called, the Normandy, is setting course for Earth.
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
");
                Console.WriteLine(@"
Press enter to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (location == "earth")
            {
                Console.WriteLine(@"***
Your ship, called, the Normandy, is setting course for Earth.
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
");
                Console.WriteLine(@"
Press enter to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("***");
                Console.WriteLine("Okay... It's not that hard to correctly type right?");
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("***");
                Console.WriteLine("I have decided: You don't get a second chance.");
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    class Item
    {

    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Game.OpeningQuestion();
            Console.Read();
        }
    }
}
