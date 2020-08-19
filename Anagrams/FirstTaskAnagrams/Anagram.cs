using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTaskAnagrams
{
    public static class Anagram
    {
        public static void IsAnagram(string firstWord, string secondWord, string newWord1, string newWord2)
        {
            if (newWord1 == newWord2)
            {
                Console.WriteLine($"{firstWord} and {secondWord} are anagrams");
            }
            else
            {
                Console.WriteLine($"{firstWord} and {secondWord} are not anagrams");
            }
        }
    }
}
