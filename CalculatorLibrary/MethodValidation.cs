using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 public static  class MethodValidation
    {
        public static Boolean CharactersAreValid(this string ThisValue)
        {
            String AllowedCharacters = "1234567890+-*/=.C";
            if (!AllowedCharacters.Contains(ThisValue))
                return false;
            else
                return true;
                   

        }

    public static String[] GetNumbersArray(this string ThValue)
    {
        char[] splcharacters = { '+', '-', '*', '/', '=' };
         return  ThValue.Split(splcharacters);
    }

    public static Boolean ThisIsValidSymbol(this string ThValue)
    {
        if (ThValue == "+" || ThValue == "-"
                                || ThValue == "*"
                                || ThValue == "/"
                                || ThValue == "=")
            return true;
        else
            return false;
    }

}

