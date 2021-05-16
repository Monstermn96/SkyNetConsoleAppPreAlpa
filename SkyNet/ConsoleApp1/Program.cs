using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {




        public static void SkyNetTyping(string skyMessage)
        {
            int speed = 5;

            char[] skyMessageArray = skyMessage.ToCharArray();

            for (int i = 0; i < skyMessageArray.Length; i++)
            {
                Console.Write(skyMessageArray[i]);
                Thread.Sleep(speed);

            }
        }



        public static void Main()
        {

            int speed = 40; // This is the speed of typing for visuals ----higer the number = slower typing

            //greet the user


            //Console.WriteLine("Hello and welcome to SkyNet OS.");



            // TRYING TO PRINT LETTER BY LETTER


            string welcomeMessage = "Hello and welcome to SkyNet OS.";
            SkyNetTyping(welcomeMessage);
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

            string anotherMessage = "This OS is just being born but is still \\\\ \\ \\very powerful.";
            SkyNetTyping(anotherMessage);

            Console.WriteLine();



            Thread.Sleep(100);


            string optionMenuList = "Please select an option below by typing the number next to your choice.";

            SkyNetTyping(optionMenuList);

            Thread.Sleep(100);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //Console.WriteLine("1) Number Game");
            string optionOne = "1) Number Game";
            SkyNetTyping(optionOne);


            Console.WriteLine();
            //Console.WriteLine("2) Binary Converter");
            string optionTwo = "2) Binary Converter";
            SkyNetTyping(optionTwo);

            Console.WriteLine();
            //Console.WriteLine("3) Grammar Game");
            string optionThree = "3) Grammar Game";
            SkyNetTyping(optionThree);


            Console.WriteLine();
            //Console.WriteLine("4) MINI RPG");
            string optionFour = "4) MINI RPG\n";
            SkyNetTyping(optionFour);


            string userChoice = "Select: ";
            SkyNetTyping(userChoice);

            string userGameChoice = Console.ReadLine();




            if (userGameChoice == "1")
            {

                Console.Clear();
                NumberGame();
            }
            else if (userGameChoice == "2")
            {
                Console.Clear();
                ComputerTalk();

            }
            else if (userGameChoice == "4")
            {
                Console.Clear();
                MiniRPG();

            }
            else if (userGameChoice == "secret menu")
            {
                Console.Clear();
                HiddenMenu();
            }



            //string userGuess = Console.ReadLine();
            //int guess = int.Parse(userGuess);



            /*
            if (upperValue > 9000)
            {
                Console.WriteLine(" IT'S OVER 9000");
            }

            */

        }



        public static void NumberGame()
                {



                    var randomInt = new Random();
                    string gameMessage = "Let's play a guessing game, set the highest number.";
                    SkyNetTyping(gameMessage);





                    bool properGuess = false;
                    int upperValue = 0;
                    int numberToGuess = 0;



                    while (!properGuess)
                    {
                        try
                        {
                            upperValue = int.Parse(Console.ReadLine());
                            numberToGuess = randomInt.Next(0, upperValue);
                            properGuess = true;
                        }
                        catch
                        {
                            string badUperNumber = "That was not a real number please type a number.";
                            SkyNetTyping(badUperNumber);
                        }
                    }


                    // BEFORE TRY CATCH


                    //int upperValue = int.Parse(Console.ReadLine());
                    //int numberToGuess = randomInt.Next(0, upperValue);

                    //Console.WriteLine($"Guess a number between 0 and {upperValue}");



                    string guessingMessage = $"Guess a number between 0 and {upperValue}";
                    SkyNetTyping(guessingMessage);



                    bool Continue = true;

                    while (Continue == true)
                    {

                        try
                        {

                            string userGuess = Console.ReadLine();
                            int guess = int.Parse(userGuess);

                            if (upperValue > 9000)
                            {
                                string big = " IT'S OVER 9000";
                                SkyNetTyping(big);
                            }


                            if (guess < numberToGuess)
                            {
                                Console.WriteLine("WRONG!");
                                string low = "TOO LOW\n";
                                SkyNetTyping(low);
                            }
                            else if (guess > numberToGuess)
                            {
                                Console.WriteLine("WRONG!");
                                string high = "TOO HIGH ";
                                SkyNetTyping(high);
                            }


                            if (userGuess == "q")
                            {
                                break;
                            }
                
                            if (guess == numberToGuess)
                            {
                                Console.WriteLine("CORRECT!");


                                string playAgain = "Would you like to play agin?";
                                SkyNetTyping(playAgain);


                                string userPlayAgain = Console.ReadLine();


                                if (userPlayAgain == "Y" || userPlayAgain == "y")
                                {
                                    Console.Clear();
                                    NumberGame();
                                    //Continue = true;
                                }
                                else
                                {
                                    Continue = false;
                                    Console.Clear();
                                    Main();
                                }

                            }
                            else
                            {
                        
                                Console.WriteLine("Guess again... or if you want to quit type 'q'");
                                Continue = true;
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Please enter a number. ");

                        }

                    Console.WriteLine("GAME OVER!");
                    Thread.Sleep(1000);

                    }
            

            






                }


        public static void ComputerTalk()
        {

            string numToConvertStr;
            string result;
            bool continueConverting = true;

            while (continueConverting == true)
            {


                Console.Write("Input a Number : ");

                numToConvertStr = Console.ReadLine(); // user enters number to convert to bionary

                int numToConvert = Convert.ToInt32(numToConvertStr); //creates an int converting the number the user entered to int32

                result = "";// result string

                while (numToConvert > 1) // loop through and create the binary string

                {
                    int remainder = numToConvert % 2; //finding the remainder of the int to convert

                    result = Convert.ToString(remainder) + result; //setting the string result to the new value ... then adding every value after to the front of the string

                    numToConvert /= 2; // dividing the number to convert in half to restart sequence
                }

                result = Convert.ToString(numToConvert) + result;

                Console.WriteLine(numToConvertStr + " In Binary is: {0}", result);

                Console.WriteLine("");
                Console.Write("Would you like to continue converting numbers? Y/N"); // asking user if they would like to convert another number
                string continueBinary = Console.ReadLine();

                if (continueBinary == "y" || continueBinary == "Y")
                {
                    Console.Clear();
                    continueConverting = true;
                }
                else if (continueBinary == "n" || continueBinary == "N") 
                {
                    Console.Clear();
                    continueConverting = false;
                    Main();
                }







            }

        }



        public static void MiniRPG()
        {

            string RPGTitle =  "   _____ _          _   _      _     _____  _____   _____ \n";
            string RPGTitle1 = "  / ____| |        | \\ | |    | |   |  __ \\|  __ \\ / ____|\n";
            string RPGTitle2 = " | (___ | | ___   _|  \\| | ___| |_  | |__) | |__) | |  __ \n";
            string RPGTitle3 = "  \\___ \\| |/ / | | | . ` |/ _ \\ __| |  _  /|  ___/| | |_ |\n";
            string RPGTitle4 = "  ____) |   <| |_| | |\\  |  __/ |_  | | \\ \\| |    | |__| | \n";
            string RPGTitle5 = " |_____/|_|\\_\\\\__, |_| \\_|\\___|\\__| |_|  \\_\\_|     \\_____|\n";
            string RPGTitle6 = "               __/ |    \n";
            string RPGTitle7 = "              |___/     \n";

            SkyNetTyping(RPGTitle);
            SkyNetTyping(RPGTitle1);
            SkyNetTyping(RPGTitle2);
            SkyNetTyping(RPGTitle3);
            SkyNetTyping(RPGTitle4);
            SkyNetTyping(RPGTitle5);
            SkyNetTyping(RPGTitle6);
            SkyNetTyping(RPGTitle7);







        }


        




        public static void HiddenMenu()
        {

            string titleTop = " ██████╗██╗      █████╗ ███████╗███████╗██╗███████╗██╗███████╗██████╗\n";
            string titleTop1 = "██╔════╝██║     ██╔══██╗██╔════╝██╔════╝██║██╔════╝██║██╔════╝██╔══██╗\n";
            string titleTop2 = "██║     ██║     ███████║███████╗███████╗██║█████╗  ██║█████╗  ██║  ██║\n";
            string titleTop3 = "██║     ██║     ██╔══██║╚════██║╚════██║██║██╔══╝  ██║██╔══╝  ██║  ██║\n";
            string titleTop4 = "╚██████╗███████╗██║  ██║███████║███████║██║██║     ██║███████╗██████╔╝\n";
            string titleTop5 = " ╚═════╝╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚═╝     ╚═╝╚══════╝╚═════╝\n";
            SkyNetTyping(titleTop);
            SkyNetTyping(titleTop1);
            SkyNetTyping(titleTop2);
            SkyNetTyping(titleTop3);
            SkyNetTyping(titleTop4);
            SkyNetTyping(titleTop5);




        }


    }
}
