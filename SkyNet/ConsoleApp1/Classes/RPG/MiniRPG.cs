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

            Console.WriteLine("\n Pess \"ENTER\" to cause system overload...");
            Console.ReadLine();

            Console.Clear();

            string enteringTheNet = "now entering skynet..";
            OSMain.SkyNetTyping(enteringTheNet, 40);

            string hackingTheNet = $"\n\n****BRUTEFORCE HACK DETECTED BY USER: {PlayerID[0].PlayerName} DEPLOYING COUNETMEASUERS****";
            OSMain.SkyNetTyping(hackingTheNet, 60);
            Thread.Sleep(400);

            string hackingTheNet1 = $"\n\n{PlayerID[0].PlayerName}: {PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}   \n{PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}   \n{PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}   {PlayerID[0].PlayerCatchPhrase}";
            OSMain.SkyNetTyping(hackingTheNet1, 5);


            Thread.Sleep(400);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("001011011001010101010100101001001010101011100001010101001010101001");
                Thread.Sleep(1);
                Console.WriteLine("101010101010001001010100101001010100100010000100001000010000010011");
                Thread.Sleep(1);
                Console.WriteLine("000101001010101010101001010100101010100111010010010010101101101010");
                Thread.Sleep(1);
            }
            Thread.Sleep(800);
            Console.Clear();

            






            // player has entered skynet decisions start here

            string startingPoint = "Anonymous: You have made passed SkyNet's firewall your goal now, is to shut down SkyNet...";
            OSMain.SkyNetTyping(startingPoint, typingSpeed);

            string startingPoint1 = "\n\nAnonymous: You will be asked many questions on your journy just be careful because\nthey are security questions being asked by SkyNet's center of security,\nand will prevent you from getting to where you need to be.\n\n PRESS ENTER TO CONTINUE...";
            OSMain.SkyNetTyping(startingPoint1, typingSpeed);


            Console.ReadLine();



            string startingPoint2 = "\nAnonymous: saying more things as a test";
            OSMain.SkyNetTyping(startingPoint2, typingSpeed);



        }

    }
}
