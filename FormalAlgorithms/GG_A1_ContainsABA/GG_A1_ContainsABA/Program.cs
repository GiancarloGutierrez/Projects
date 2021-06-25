//                      Giancarlo Gutierrez
//                     CS 4110 - Online
//                      Assignment #1 - #5 Language ContainsABA
//                      Dr. Rague
//                      Due: 05/27/21
//                      Version: 1.0
// -----------------------------------------------------------------
// The Program tests if a word is in the Language ContainsABA and returns
// true if it is and false if it is not
// -----------------------------------------------------------------



// Directive Inclusions
using System;

namespace GG_A1_ContainsABA
{
    // -----------------------------------------------------------------
    // The Main class, that determines if a word is in the language
    // ContainsABA
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
                result = ContainsABA(valueString);


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

        //Function to determine if a word is in the language ContainsABA defined by:
        // (1) Word aba is in ContainsABA
        // (2) If w is in ContainsABA, then so are aw, wa, bw, and wb.
        // (3) Only words created from rules (1) and (2) are in ContainsABA, all others
        //      are excluded.
        static private bool ContainsABA(string val)
        {
            int length = val.Length; //get value length

            //If length is less than 3 cannot be in language
            //return false
            if (length < 3)
                return false;
            //If the first and last character is not a or b it cannot
            //be in the language, return false
            //this tests before the first/last character is removed
            if (
                (val[0].CompareTo('a') != 0          &&
               val[0].CompareTo('b') != 0)           ||
               (val[length - 1].CompareTo('a') != 0  &&
               val[length - 1].CompareTo('b') != 0))
                return false;

            //If the string is equal to abc at this point, the word is in the language
            //return true
            if (val.CompareTo("aba") == 0)
                return true;

            //If either the last three characters are aba or the first 
            //3 characters are, then it is a possible language
            //the rest of the iteration will remove characteres while testing
            //until the string is only left with aba at which point the word
            //is in the language

            string next = ""; //the next string to be processed
            //first 3 letter check
            if (
                val[0].CompareTo('a') == 0 &&
                val[1].CompareTo('b') == 0 &&
                val[2].CompareTo('a') == 0) 
            {
                //remove last character
                for(int i = 0; i < length - 1; i++)
                {
                    next += val[i];
                }
            }
            //last 3 letter check
            else if (val[length-3].CompareTo('a') == 0 &&
                val[length-2].CompareTo('b') == 0 &&
                val[length-1].CompareTo('a') == 0)
            {
                //remove first character
                for(int i = 1; i < length; i++)
                {
                    next += val[i];
                }
            }
            else
            {
                //remove first and last character
                for(int i = 1; i < length -1; i++)
                {
                    next += val[i];
                }
            }
                                //retest values for new string
            return ContainsABA(next);
        }

    }
}
