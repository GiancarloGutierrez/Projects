//                      Giancarlo Gutierrez
//                     CS 4110 - Online
//                      Assignment #1 - #6 Language ABPlus
//                      Dr. Rague
//                      Due: 05/27/21
//                      Version: 1.0
// -----------------------------------------------------------------
// The Program tests if a word is in the Language ABPlus and returns
// true if it is and false if it is not
// -----------------------------------------------------------------



// Directive Inclusions
using System;

namespace GG_A1_ABPlus
{
    // -----------------------------------------------------------------
    // The Main class, that determines if a word is in the language
    // ABPlus
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
                
                result = ABPlus(valueString);


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

        //Function to determine if a word is in the language ABPlus defined by:
        //  Alphabet = {a b + }
        // (1) Words a and b are in ABPlus
        // (2) If v and w are in ABPlus, then so are vw and v+w
        // (3) Only words created by the rules (1) and (2) are in ABPlus all
        //      others are excluded.
        static private bool ABPlus(string val)
        {
            int length = val.Length;    //get the value length
                                        //if value is a it is in the language return true
            if (val.CompareTo("a") == 0)
                return true;
                                        //if value is b it is in the language return true
            if (val.CompareTo("b") == 0)
                return true;

                               //if 1 character or less and not a or b then not in language
                               //return false
            if(length <= 1)
                return false;


            string next = ""; //create string for next test value

                            //if value starts with vw then remove the first value from next test value
            if(
                (val[0].CompareTo('a')==0 || val[0].CompareTo('b')==0)
                &&
                (val[1].CompareTo('a')==0 || val[1].CompareTo('b')==0)
                )
            {
                            //remove first letter of test word
                for(int i = 1; i <length; i++)
                {
                    next += val[i];
                }
            }
                        //if value ends with vw then remove last value from test value
            else if( (val[length-2].CompareTo('a') == 0 || val[length-2].CompareTo('b') == 0)
                &&
                (val[length-1].CompareTo('a') == 0 || val[length-1].CompareTo('b') == 0)
                )
            {
                        //remove last letter of test word
                for (int i = 0; i < length - 1; i++)
                {
                    next += val[i];
                }
            }
                    //test if v+w exits at start of word, if it does remove +
            else if(
                length> 2 && (
                        (val[0].CompareTo('a') == 0 || val[0].CompareTo('b') == 0)
                        &&
                        (val[1].CompareTo('+')==0)
                        &&
                        (val[2].CompareTo('a') == 0 || val[2].CompareTo('b') == 0)
                    )
                )
            {
                        //remove + from the v+w at start of the test string
                for(int i = 0; i<length; i++)
                {
                    if (i == 1)
                        continue;
                    else
                    {
                        next += val[i];
                    }
                }
            }
                        //test if v+w exists at end of word, if so remove +
            else if(
                    length > 2 && (
                        (val[length-3].CompareTo('a') == 0 || val[length-3].CompareTo('b') == 0)
                        &&
                        (val[length-2].CompareTo('+') == 0)
                        &&
                        (val[length-1].CompareTo('a') == 0 || val[length-1].CompareTo('b') == 0)
                    )
                )
            {
                // remove + from v+w at end of test word
                for(int i = 0; i<length; i++)
                {
                    if (i == length - 2)
                        continue;
                    else
                    {
                        next += val[i];
                    }
                }
            }
                //if a different case exists, the word is not in the language
                // return false
            else
            {
                return false;
            }
                    //test the next test string
            return ABPlus(next);
        }

    }
}
