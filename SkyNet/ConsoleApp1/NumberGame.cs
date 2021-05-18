using System;
using System.Collections.Generic;
using System.Text;

namespace SkyNetOS
{
    class NumberGame
    {


        public static void NumberGameGame()
        {


            int speed = 5;


            var randomInt = new Random();
            string gameMessage = "Let's play a guessing game, set the highest number.";
            OSMain.SkyNetTyping(gameMessage, speed);





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

                    if (upperValue > 9000)
                    {
                        string big = " IT'S OVER 9000!!!!!\n\n";
                        OSMain.SkyNetTyping(big, speed);
                    }

                }
                catch
                {
                    string badUperNumber = "That was not a real number please type a number.";
                    OSMain.SkyNetTyping(badUperNumber, speed);
                }
            }


            // BEFORE TRY CATCH


            //int upperValue = int.Parse(Console.ReadLine());
            //int numberToGuess = randomInt.Next(0, upperValue);

            //Console.WriteLine($"Guess a number between 0 and {upperValue}");



            string guessingMessage = $"Guess a number between 0 and {upperValue}: ";
            OSMain.SkyNetTyping(guessingMessage, speed);



            bool Continue = true;

            while (Continue == true)
            {

                try
                {

                    string userGuess = Console.ReadLine();
                    int guess = int.Parse(userGuess);
                    /*
                    if (upperValue > 9000)
                    {
                        string big = " IT'S OVER 9000!!!!!!!";
                        SkyNetTyping(big, speed);
                    }
                    */

                    if (guess < numberToGuess)
                    {
                        Console.WriteLine("WRONG!");
                        string low = "TOO LOW\n";
                        OSMain.SkyNetTyping(low, speed);
                    }
                    else if (guess > numberToGuess)
                    {
                        Console.WriteLine("WRONG!");
                        string high = "TOO HIGH ";
                        OSMain.SkyNetTyping(high, speed);
                    }


                    if (userGuess == "q")
                    {
                        break;
                    }

                    if (guess == numberToGuess)
                    {
                        Console.WriteLine("CORRECT!");


                        string playAgain = "Would you like to play agin? (Y/N)";
                        OSMain.SkyNetTyping(playAgain, speed);


                        string userPlayAgain = Console.ReadLine();


                        if (userPlayAgain == "Y" || userPlayAgain == "y")
                        {
                            Console.Clear();
                            NumberGame.NumberGameGame();
                            //Continue = true;
                        }
                        else
                        {
                            Continue = false;
                            Console.Clear();
                            OSMain.Main();
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
                    Console.WriteLine("Please enter a real number. ");

                }

                //Console.WriteLine("GAME OVER!");
                //Thread.Sleep(1000);

            }









        }


    }
}
