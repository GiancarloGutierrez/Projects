//                      Giancarlo Gutierrez
//                     CS 4110 - Online
//                      Assignment #1 - #1 Language Divisible by 7
//                      Dr. Rague
//                      Due: 05/27/21
//                      Version: 1.0
// -----------------------------------------------------------------
// This program test if the inputed value is in the language Divisible by 7
// and returns true if it is in the language and false if it is not
// -----------------------------------------------------------------



// Directive Inclusions
using System;

namespace GG_A1_D7
{
    // -----------------------------------------------------------------
    // This is the class that contains the main program, and the 
    // testing functionality for the language divisible by 7
    // Version 1.0
    // -----------------------------------------------------------------
    class Program
    {
        //Main Execution of the program
        static void Main(string[] args)
        {
            int length = args.Length;               //Retrieve and store the arg array
                                                    //length passed in through console

            if (length == 1)                         //Verify the input only contains a
                                                     //single value
            {
                bool result = false;                //result variable for if word is in language
                string resultString = "false";      //resultString variable for displaying output of result
                string valueString = args[0];       //valueString variable for displaying output of input

                if (int.TryParse(args[0], out int a))
                { //try to parse to int, if success pass into test function
                    result = DivisibleBy7(a);
                }

                if (result)                         //if result than change resultString display to true
                {
                    resultString = "true";
                }
                //display results of calcualtions
                System.Console.Write("X = " + valueString + "   Member?  " + resultString);
            }
            else                                    //If incorrect input display and
                                                    //bypass main functions
            {
                System.Console.WriteLine("Invalid Input, Only accepts 1 value");
            }
        }

        //Determines a value is in the Language Divisibleby7 defined:
        // (1) Integer 7 is in Divisibleby7
        // (2) If x is in Divisibleby7 then so is x+7
        // (3) Only words produced by rules (1) and (2) are in Dibisibleby7
        //      all other words are excluded.
        static private bool DivisibleBy7(int val)
        {
            //if equal to 7 is in language return true
            if (val == 7)
                return true;
            //if is less than 7 not in language return true
            if (val < 7)
                return false;
            //if greater than 7 must minus 7 and test again
            return DivisibleBy7(val - 7);
        }
    }
}
