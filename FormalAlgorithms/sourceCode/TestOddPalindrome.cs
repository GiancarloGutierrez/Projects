//                      Giancarlo Gutierrez
//                     CS 4110 - Online
//                      Assignment #1 - #4 Language OddPalindrome
//                      Dr. Rague
//                      Due: 05/27/21
//                      Version: 1.0
// -----------------------------------------------------------------
// The Program tests if a word is in the Language OddPalindrome and returns
// true if it is and false if it is not
// -----------------------------------------------------------------



// Directive Inclusions
using System;

namespace GG_A1_OddPalindrome
{
    // -----------------------------------------------------------------
    // The Main class, that determines if a word is in the language
    // OddPalindrome
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

                
                result = OddPalindrome(valueString);
                

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

        //Function to determine if a word is in the language OddPalindrome defined by:
        // (1) Words a and b are in OddPalindrome
        // (2) If w is a word in OddPalindrome, the so are awa and bwa (concatenation)
        // (3) Only words created by rules (1) and (2) are in OddPalindrome, all others
        //          are excluded

        static private bool OddPalindrome(string val)
        {
            int length = val.Length;        //get the val length;
                                            //if value is a is in language return true
            if (val.CompareTo("a") == 0)
                return true;
                                            //if value is b is in language return true
            if (val.CompareTo("b") == 0)
                return true;
                                            //If length is less than 2, is now impossible to
                                            //be in language return false
            if (length <= 2)
                return false;
                                            //if the first and last characters are not both a, and
                                            // are not both b, then this word cannot be a word in
                                            // the language return false
            if (
                !(val[0].CompareTo('a') == 0 && val[length - 1].CompareTo('a') == 0)
                &&
                !(val[0].CompareTo('b') == 0 && val[length - 1].CompareTo('b') == 0)
                )
                return false;
                                            //Prep for next test by removing first and last characters
            string next = "";
            for(int i = 1; i < val.Length-1; i++)
            {
                next += val[i];
            }
                                        //Test the new reduced word to see if it is the language;
            return OddPalindrome(next);
        }

    }
}
