using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTaskAnagrams
{
    public static class Walidation
    {
        public static void IsWalid(string firstWord,string secondWord)
        {
            int number = 0;
            bool isNumber1 = int.TryParse(firstWord, out number);
            bool isNumber2 = int.TryParse(secondWord, out number);
            if (isNumber1 == true | isNumber2 == true | String.IsNullOrEmpty(firstWord) | String.IsNullOrEmpty(secondWord))
            {
                Console.WriteLine($"Given words cant be number, null or empty");
            }
            else
            {
                Console.WriteLine("Walidation correct");
            }
        }
    }
}
