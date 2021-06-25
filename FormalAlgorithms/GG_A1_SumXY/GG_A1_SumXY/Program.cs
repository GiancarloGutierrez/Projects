//                      Giancarlo Gutierrez
//                     CS 4110 - Online
//                      Assignment #1 - #3 Language SumXY
//                      Dr. Rague
//                      Due: 05/27/21
//                      Version: 1.0
// -----------------------------------------------------------------
// The Program tests if a word is in the Language SumXY and returns
// true if it is and false if it is nots
// -----------------------------------------------------------------



// Directive Inclusions
using System;

namespace GG_A1_SumXY
{
    // -----------------------------------------------------------------
    // The Main class, that determines if a word is in the language
    // SumXY
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

                if (int.TryParse(args[0], out int a))
                { //try to parse to int, if success pass into test function
                    result = SumXY(a);
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

        //Function to determine if a word is in the language SumXY defined by:
        // (1) Integers 17 and 43 are in SumXY
        // (2) If x and y are in SumXY, then x+y is in SumXY
        // (3) Only words creaated by rules (1) and (2) are in SumXY, all other
        // words are excluded

        //first entry val1 and 2 are equal
        static private bool SumXY(int val)
        {
                                //If value is 17 is in SumXY, return true
            if (val == 17)
                return true;
                                //If value is 43 is in SumXY, return true
            if (val == 43)
                return true;
                                //If value is less than 17, is not in SumXy return false
            if (val < 17)
                return false;
                                //If value is greater than 17, try two paths both -17, and -43
                                //If either path is true return true
            return SumXY(val - 17) || SumXY(val - 43);
        }

    }
}
