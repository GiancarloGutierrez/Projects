//                      Giancarlo Gutierrez
//                     CS 4110 - Online
//                      Assignment #1 - #2 Language Powers Of 2
//                      Dr. Rague
//                      Due: 05/27/21
//                      Version: 1.0
// -----------------------------------------------------------------
// The Program tests if a word is in the Language PowersOf2 and returns
// true if it is and false if it is nots
// -----------------------------------------------------------------



// Directive Inclusions
using System;

namespace GG_A1_P2
{
    // -----------------------------------------------------------------
    // The Main class, that determines if a word is in the language
    // PowersOf2
    // Version 1.0
    // -----------------------------------------------------------------
    class Program
    {
        //Main Function
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

                if (double.TryParse(args[0], out double a))
                { //try to parse to int, if success pass into test function
                    result = PowersOfTwo(a);
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
        //Function to tell if a word is in the language PowersOf2 Defined by:
        // (1) Integer 1 is in PowersOf2
        // (2) It x is in PowersOf2, then so is 2x
        // (3) Only words created from rules (1) and (2) are in PowersOf2, all
        //      other words are excluded

        static private bool PowersOfTwo(double val)
        {
                                                    //If value equals 1 is in language
                                                    //return true
            if (val == 1)
                return true;
                                                    //If value is less than 1 is not in
                                                    //language return false
            if (val < 1)                           
            {
                return false;
            }
                                                    //If larger than 1 divide by 2 and test
                                                    //again
            return PowersOfTwo(val / 2);
        }

    }
}
