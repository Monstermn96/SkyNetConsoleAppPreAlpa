using System;
using System.Collections.Generic;
using System.Text;

namespace SkyNetOS
{
    class MiniRPG
    {


        public static void SkyNetRPG()
        {
            int userBeingDumb = 0;
            int titleSpeed = 0; // instantly print the title
            int typingSpeed = 50; // regular text speed

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


            string welcomeRPG = "\n\n\nHello and welcome to the SkyNet RPG this game is under development\nand probably a lot of game breaking bugs........ now to explain the game.......\n\n\nIts Judgment Day..... there are no rules use what ever it take to make it to the end\nthere is no saving so any progress made wil be lost for ever in the Net";
            OSMain.SkyNetTyping(welcomeRPG, typingSpeed);


            Console.WriteLine("\nPlease Tell me your name and press ENTER to start: ");

            string userName = Console.ReadLine();

            if (userName == "")
            {
                Console.WriteLine("Please anter a name: ");

            }

        }

    }
}
