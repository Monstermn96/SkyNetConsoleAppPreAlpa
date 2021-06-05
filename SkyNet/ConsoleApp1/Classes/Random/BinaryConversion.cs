using System;
using System.Collections.Generic;
using System.Text;

namespace SkyNetOS
{
    class BinaryConversion
    {
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
                    OSMain.Main();
                }

            }

        }




    }
}
