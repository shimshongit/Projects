using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
   public class ReturnAsString
    {
        private static string[] upToTwenty =
      {
            "","one","two","three","four","five","six","seven","eight","nine","ten","eleven",
             "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"
        };
        private static string[] tens =
        {
         "","","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"
        };
        // will take in any number break it up and return each numbers place in the proper array
        public static String changeToString(int number)
        {
            if (number < 20)
            {
                return (upToTwenty[number]);
            }
            else if (number < 100)
            {
                return tens[number / 10] + " " + changeToString(number % 10);
            }
            else if (number < 1000)
            {
                return upToTwenty[number / 100] + " " + "hundred" + " " + changeToString(number % 100);
            }
            else if (number < 1000000)
            {
                return changeToString(number / 1000) + " " + "thousand" + " " + changeToString(number % 1000);
            }
            else
            {
                return "number to high";
            }
        }
    }
}
