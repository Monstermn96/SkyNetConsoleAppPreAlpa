using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        int speed = 1; // This is the speed of typing for visuals ----higer the number = slower typing

        static void Main(string[] args)
        {



            int speed = 20; // This is the speed of typing for visuals ----higer the number = slower typing

            //greet the user


            //Console.WriteLine("Hello and welcome to SkyNet OS.");




            // TRYING TO PRINT LETTER BY LETTER


            string welcomeMessage = "Hello and welcome to SkyNet OS."; 

            char[] welcomeArray = welcomeMessage.ToCharArray();

            for (int i = 0;i < welcomeArray.Length ;i++)
            {
                Console.Write(welcomeArray[i]);
                Thread.Sleep(speed);

            }
            Console.WriteLine();








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
            Console.WriteLine("\n");
            Thread.Sleep(50);

            Thread.Sleep(1000);

            //Console.WriteLine("This OS is just being born but is still very powerful.");

            string anotherMessage = "This OS is just being born but is still very powerful.";

            char[] anotherArray = anotherMessage.ToCharArray();

            for (int i = 0; i < anotherMessage.Length; i++)
            {
                Console.Write(anotherArray[i]);
                Thread.Sleep(speed);

            }
            Console.WriteLine();



            Thread.Sleep(100);


            string optionMenuList = "Please select an option below by typing the number next to your choice.";

            char[] optionMenuListArray = optionMenuList.ToCharArray();

            for (int i = 0; i < optionMenuListArray.Length; i++)
            {
                Console.Write(optionMenuListArray[i]);
                Thread.Sleep(speed);

            }

            Thread.Sleep(100);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1) Number Game");





            string userGameChoice = Console.ReadLine();







            if (userGameChoice == "1")
            {

                Console.Clear();
                NumberGame();
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

            int speed = 20; // This is the speed of typing for visuals ----higer the number = slower typing

            var randomInt = new Random();
            string gameMessage = "Let's play a guessing game, set the highest number.";
            char[] gameMessageArray = gameMessage.ToCharArray();

            for (int i = 0; i < gameMessageArray.Length; i++)
            {
                Console.Write(gameMessageArray[i]);
                Thread.Sleep(speed);
            }




            int upperValue = int.Parse(Console.ReadLine());
            int numberToGuess = randomInt.Next(0, upperValue);
            Console.WriteLine($"Guess a number between 0 and {upperValue}");








            bool Continue = true;

            while (Continue == true)
            {
                string userGuess = Console.ReadLine();
                int guess = int.Parse(userGuess);

                if (upperValue > 9000)
                {
                    Console.WriteLine(" IT'S OVER 9000");
                }


                if (guess < numberToGuess)
                {
                    Console.WriteLine("TOO LOW");
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine("TOO HIGH");
                }



                if (userGuess == "q")
                {
                    break;
                }
                ;
                if (guess == numberToGuess)
                {
                    Console.WriteLine("CORRECT!");




                    Console.WriteLine("Would you like to play agin?");




                    string userPlayAgain = Console.ReadLine();


                    if (userPlayAgain == "Y" || userPlayAgain == "y")
                    {
                        Continue = true;
                    }
                    else
                    {
                        Continue = false;
                    }


                }
                else
                {
                    Console.WriteLine("WRONG!");
                    Console.WriteLine("Guess again... or if you want to quit type 'q'");
                    Continue = true;
                }
            }
            Console.WriteLine("GAME OVER!");







        }







    }
}
