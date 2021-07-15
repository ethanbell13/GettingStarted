using System.Collections.Generic;

namespace GettingStartedLibrary
{
    //Based on pages 2 & 3 of https://www.itu.int/dms_pubrec/itu-r/rec/m/R-REC-M.1677-1-200910-I!!PDF-E.pdf
    public static class StringToMorseCode
    {
        public static Dictionary<char, string> morseCodeDict = new Dictionary<char, string>()
        {
            {'a',".-"}, {'b',"-..."}, {'c',"-.-."},{'d',"-.." }, {'e',"."},{'f',"..-."},{'g',"--."},{'h',"...."},
            {'i',".."},{'j',".---"},{'k',"-.-"},{'l',".-.."},{'m', "--" },{'n',"-." },{'o',"---"},{'p',".--."},
            {'q', "--.-"},{'r',".-."},{'s',"..."},{'t',"-"},{'u',"..-"},{'v',"...-"},{'w',".--"},{'x',"-..-"},
            {'y',"-.--" },{'z',"--.."},{'0',"-----"},{'1',".----"},{'2',"..---"},{'3',"...--"},{'4',"....-"},
            {'5',"....." },{'6',"-...."},{'7',"--..."},{'8',"---.."},{'9',"----."},{'.',".-.-.-"},{',',"--..--"},
            {':',"---..." },{'?',"..--.."},{'\'',".----."},{'-',"-....-"},{'/',"-..-."},{'(',"-.--."},{')',"-.--."},
            {'\"',".-..-." },{'=',"-...-"}, {'+',".-.-."}, {'@',".--.-."}, {' ', "       "}, {'*',"-..-"}
        };

        public static string StringToMorseCodeTranslator(string str, Dictionary<char, string> dic)
        {
            var lowerStr = str.ToLower();
            var translation = "-.-.-";
            for(int i = 0; i < lowerStr.Length; i++)
            {
                var condition = false;
                if ((i + 10) <= lowerStr.Length)
                {
                    if (lowerStr.Substring(i, 10) == "understood")
                    {
                        translation += "...-.";
                        i += 9;
                        condition = true;
                    }
                }
                if ((i + 5) <= lowerStr.Length)
                {
                    if (lowerStr.Substring(i, 5) == "error")
                    {
                        translation += "........";
                        i += 4;
                        condition = true;
                    }
                }
                if ((i + 22) <= lowerStr.Length)
                {
                    if (lowerStr.Substring(i, 22) == "invitation to transmit")
                    {
                        translation += "-.-";
                        i += 21;
                        condition = true;
                    }
                }
                if ((i + 4) <= lowerStr.Length)
                {
                    if(lowerStr.Substring(i, 4) == "wait")
                    {
                        translation += ".-...";
                        i += 3;
                        condition = true;
                    }
                }
                if ((i + 11) <= lowerStr.Length)
                {
                    if(lowerStr.Substring(i, 11) == "end of work")
                    {
                        translation += "...-.-";
                        i += 10;
                        condition = true;
                    }
                }
                if(condition == false)
                {
                    translation += dic[lowerStr[i]];
                    if (lowerStr[i] != ' ' && lowerStr[i + 1] != ' ' && (i + 1) != lowerStr.Length) translation += "   ";
                }
            }
            return translation;
        }
       
    }
}








