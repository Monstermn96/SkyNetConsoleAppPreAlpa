using System;
using System.Threading;

namespace SkyNetOS
{
    public class OSMain
    {
        public static void SkyNetTyping(string skyMessage, int speed)
        {
            //int speed = 5;

            //char[] skyMessageArray = skyMessage.ToCharArray(); // no longer need this line because string are already an array

            for (int i = 0; i < skyMessage.Length; i++)
            {
                Console.Write(skyMessage[i]);
                Thread.Sleep(speed);

            }
        }


        public static void Main()
        {

            int speed = 5; // This is the speed of typing for visuals ----higer the number = slower typing

            //greet the user
            // TRYING TO PRINT LETTER BY LETTER
            int userBeingDumb = 0;


            string welcomeMessage = "Hello and welcome to SkyNet OS.";
            SkyNetTyping(welcomeMessage, speed);
            Console.WriteLine("");


            Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Thread.Sleep(speed);
            Console.WriteLine("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Thread.Sleep(speed);
            Console.WriteLine("█░░║║║╠─║─║─║║║║║╠─░░█");
            Thread.Sleep(speed);
            Console.WriteLine("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Thread.Sleep(speed);
            Console.WriteLine("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Thread.Sleep(50);
            Console.WriteLine("\n");
            Thread.Sleep(50);
            Console.WriteLine("\n");
            Thread.Sleep(50);
            Console.WriteLine("\n");
            Thread.Sleep(50);

            Thread.Sleep(800);

            //Console.WriteLine("This OS is just being born but is still very powerful.");

            string anotherMessage = "This OS is just being born but is still very powerful.";
            SkyNetTyping(anotherMessage, speed);

            Console.WriteLine();


            Thread.Sleep(100);

            // ########################################################    OPTION MENU   ###########################################################

            string optionMenuList = "Please select an option below by typing the number next to your choice.";

            SkyNetTyping(optionMenuList, speed);

            Thread.Sleep(100);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //Console.WriteLine("1) Number Game");
            string optionOne = "1) Number Game";
            SkyNetTyping(optionOne, speed);


            Console.WriteLine();
            //Console.WriteLine("2) Binary Converter");
            string optionTwo = "2) Binary Converter";
            SkyNetTyping(optionTwo, speed);

            Console.WriteLine();
            //Console.WriteLine("3) Grammar Game");
            string optionThree = "3) Grammar Game";
            SkyNetTyping(optionThree, speed);


            Console.WriteLine();
            //Console.WriteLine("4) MINI RPG");
            string optionFour = "4) MINI RPG\n";
            SkyNetTyping(optionFour, speed);


            string userChoice = "Select: ";
            SkyNetTyping(userChoice, speed);

            string userGameChoice = Console.ReadLine();
            try
            {
                bool userIsThinking = true;

                while (userIsThinking == true)
                {
                    if (userGameChoice == "1")
                    {
                        Console.Clear();
                        NumberGame.NumberGameGame();
                        userIsThinking = false;
                    }
                    else if (userGameChoice == "2")
                    {
                        Console.Clear();
                        BinaryConversion.ComputerTalk();
                        userIsThinking = false;

                    }
                    else if (userGameChoice == "4")
                    {
                        Console.Clear();
                        MiniRPG.SkyNetRPG();
                        userIsThinking = false;

                    }
                    else if (userGameChoice == "secret menu")
                    {
                        Console.Clear();
                        HiddenMenu();
                        userIsThinking = false;
                    }
                    else
                    {
                        string optionCatch = "That is not a Menu item please choose one of the 4 items...";
                        SkyNetTyping(optionCatch, speed);

                        if (userBeingDumb > 4)
                        {
                            string userNotListining = "Now you get to wait while I reboot....good job.";
                            SkyNetTyping(userNotListining, 100);
                            Console.Clear();
                            Main();
                        }
                        userBeingDumb++;
                    }
                }


            }
            catch
            {
                
            }


            // ######################################################    OPTION MENU   ############################################################


        }


        public static void HiddenMenu()
        {
            int speed = 1;

            string titleTop = " ██████╗██╗      █████╗ ███████╗███████╗██╗███████╗██╗███████╗██████╗\n";
            string titleTop1 = "██╔════╝██║     ██╔══██╗██╔════╝██╔════╝██║██╔════╝██║██╔════╝██╔══██╗\n";
            string titleTop2 = "██║     ██║     ███████║███████╗███████╗██║█████╗  ██║█████╗  ██║  ██║\n";
            string titleTop3 = "██║     ██║     ██╔══██║╚════██║╚════██║██║██╔══╝  ██║██╔══╝  ██║  ██║\n";
            string titleTop4 = "╚██████╗███████╗██║  ██║███████║███████║██║██║     ██║███████╗██████╔╝\n";
            string titleTop5 = " ╚═════╝╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚═╝     ╚═╝╚══════╝╚═════╝\n";
            SkyNetTyping(titleTop, speed);
            SkyNetTyping(titleTop1, speed);
            SkyNetTyping(titleTop2, speed);
            SkyNetTyping(titleTop3, speed);
            SkyNetTyping(titleTop4, speed);
            SkyNetTyping(titleTop5, speed);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string classifiedMenu = "This menu is highly classified and requires a TC-5 clearence level to access.";
            SkyNetTyping(classifiedMenu, 20);



        }


    }
}
