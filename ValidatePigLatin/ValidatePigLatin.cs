/*
 * Provided is a function that will take in a string, and output this string in Pig Latin
 * according to the following rules:
 * Rules of Pig Latin:
 * 1. If the string starts with a consonant, all leading consonants are moved to the end
 *	 of the string
 * 2. If the string starts with a vowel (a,e,i,o,u,y) the first vowel is moved to the end
 *	 of the string
 * 3. "ay" is always added to the end of the string
 *
 * This function has a number of defects.
 *
 * Step 1: Privide test input to this function to discover the defects.  The code is not
 * to be referred to during this step (i.e. Black box testing).
 *
 * Step 2: Debug to code and resolve the issues found in Step 1 (code can be referred to
 * in this step).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidatePigLatin
{
    class ValidatePigLatin
    {
        static void Main(string[] args)
        {
            ConvertToPigLatin c = new ConvertToPigLatin();
            String output = "",
              input = "I need a Vacation";

            if (c.ConvertStringToPigLatin(input,  ref output))
            {
                Console.WriteLine("Input: " + input);
                Console.WriteLine("PigLatin: " + output);
            }
            else
                Console.WriteLine("Failed.");

            return;
        }
    }
}
