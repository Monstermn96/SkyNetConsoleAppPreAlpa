using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SkyNetOS
{
    class MiniRPG
    {
        static List<Player> PlayerID = new List<Player>();


        public static void SkyNetRPG()
        {
            //int userBeingDumb = 0;
            int titleSpeed = 0; // instantly print the title
            int typingSpeed = 15; // regular text speed

            string RPGTitle = "   _____ _          _   _      _     _____  _____   _____ \n";
           string RPGTitle1 = "  / ____| |        | \\ | |    | |   |  __ \\|  __ \\ / ____|\n";
            string RPGTitle2 = " | (___ | | ___   _|  \\| | ___| |_  | |__) | |__) | |  __ \n";
            string RPGTitle3 = "  \\___ \\| |/ / | | | . ` |/ _ \\ __| |  _  /|  ___/| | |_ |\n";               //Title 
            string RPGTitle4 = "  ____) |   <| |_| | |\\  |  __/ |_  | | \\ \\| |    | |__| | \n";
            string RPGTitle5 = " |_____/|_|\\_\\\\__, |_| \\_|\\___|\\__| |_|  \\_\\_|     \\_____|\n";
            string RPGTitle6 = "               __/ |    \n";
            string RPGTitle7 = "              |___/     \n";

            OSMain.SkyNetTyping(RPGTitle, titleSpeed);
            OSMain.SkyNetTyping(RPGTitle1, titleSpeed);
            OSMain.SkyNetTyping(RPGTitle2, titleSpeed);
            OSMain.SkyNetTyping(RPGTitle3, titleSpeed);             // calling typing method to type
            OSMain.SkyNetTyping(RPGTitle4, titleSpeed);
            OSMain.SkyNetTyping(RPGTitle5, titleSpeed);
            OSMain.SkyNetTyping(RPGTitle6, titleSpeed);
            OSMain.SkyNetTyping(RPGTitle7, titleSpeed);


            string welcomeRPG = "\n\n\nHello and welcome to the SkyNet RPG this game is under development\nand probably a lot of game breaking bugs... now to explain the game...\n\n\nIt's Judgment Day... there are no rules. Use what ever it takes to make it to the end.\nThere is no saving, so any progress made wil be lost forever to SkyNet";
            OSMain.SkyNetTyping(welcomeRPG, typingSpeed);


            Console.WriteLine("\n\nPlease verify name and press ENTER to start: ");

            string characterName = Console.ReadLine();


           
            string ageVerify = $"\n{characterName} please verify age: ";
            OSMain.SkyNetTyping(ageVerify, typingSpeed);

            string stringAge = Console.ReadLine();
            int userAge = int.Parse(stringAge);


            string createUserCatchphrase = $"\n{characterName} tell me your catchphrase: ";
            OSMain.SkyNetTyping(createUserCatchphrase, typingSpeed);
            string characterPhrase = Console.ReadLine();


            Player user = new Player(characterName, userAge, characterPhrase);

            PlayerID.Add(user);



            string verifyRiddle = "\nWhat are you feeling, if you are \":(\"? ";
            OSMain.SkyNetTyping(verifyRiddle, typingSpeed);
            string riddle = Console.ReadLine().ToLower();

            if (riddle == "sad")
            {
                Console.Clear();
                StoryStart();
            }

            else
            {
                string verifyRiddleFail = "\nYOU HAVE FAILED VERIFICATION PLEASE WAIT WHILE THE SYSTEM REBOOTS... ";
                OSMain.SkyNetTyping(verifyRiddleFail, typingSpeed);

                Thread.Sleep(1000);

                Console.Clear();
                SkyNetRPG();
            }




        }

        public static void StoryStart()
        {
            int typingSpeed = 28;

            
            string storyStart = $"Welcome {PlayerID[0].PlayerName}, I understand you really like to say {PlayerID[0].PlayerCatchPhrase}";// trying to get player obj to display info in string
            OSMain.SkyNetTyping(storyStart, typingSpeed);


            string startreply = $"\n... But I will ask you to please refrain from saying it because it really doesnt make sense\nand it causes me to run into system errors.";
            OSMain.SkyNetTyping(startreply, 45);
















        }

    }
}
