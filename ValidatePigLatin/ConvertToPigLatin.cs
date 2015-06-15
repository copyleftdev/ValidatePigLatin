using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidatePigLatin
{
    class ConvertToPigLatin
    {
        bool IsVowel(char chr)
        {
            if (chr == 'a'  || chr == 'e' || chr == 'i' || chr == 'o' || chr == 'u' || chr == 'y' || chr == 'A' || chr == 'E' || chr == 'I' || chr == 'O' || chr == 'U' || chr == 'Y')
                return true;
            else
                return false;
        }

        bool ConvertWordToPigLatin(String strIn, ref String strOut)
        {
            if (strIn.Length <= 0)
                return false;

            if (IsVowel(strIn[0]))
            {
                strOut += strIn.Substring(1, strIn.Length - 1);
                strOut += strIn[0];
            }
            else
            {
                int i = 0;
                String tmpStr = "";
                while (!IsVowel(strIn[i]))
                {
                    tmpStr += strIn[i];
                    ++i;
                }
                strOut += strIn.Substring(i);
                strOut += tmpStr;
            }
            if (strOut == strOut.ToLower()) {
                strOut += "ay";
            }
            else if (strOut == strOut.ToUpper())
            {
                strOut += "AY";
            }
            else
            {
                strOut += "ay";
            }
            
            return true;
        }

        public bool ConvertStringToPigLatin(String strIn, ref String strOut)
        {
            if (strIn.Length <= 0)
                return false;

            int wordDelimiter = -1,
                stringIndex = 0;

            do
            {
                wordDelimiter = strIn.IndexOf(' ', stringIndex);
                int end = wordDelimiter > 0 ? wordDelimiter - stringIndex : strIn.Length - stringIndex;
                string tmpWord = strIn.Substring(stringIndex, end);
                if (!ConvertWordToPigLatin(tmpWord, ref strOut))
                    return false;
                if (wordDelimiter > 0)
                    strOut += " ";
                stringIndex = wordDelimiter + 1;
            } while (wordDelimiter > 0);

            return true;
        }
    }
}
