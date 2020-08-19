using System;
using System.Text;

namespace FirstTaskAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstWord = "";
            var secondWord = "";
            do
            {
                Console.WriteLine("Please, write first word");
                firstWord = Console.ReadLine();
                Console.WriteLine("Please, write second word");
                secondWord = Console.ReadLine();

                Walidation.IsWalid(firstWord, secondWord);

                var charTab1 = firstWord.ToLower().ToCharArray();
                var charTab2 = secondWord.ToLower().ToCharArray();

                Array.Sort(charTab1);
                Array.Sort(charTab2);

                var newWord1 = new string(charTab1);
                var newWord2 = new string(charTab2);

                Anagram.IsAnagram(firstWord, secondWord,newWord1,newWord2);

            } while (firstWord.ToLower() != "exit" & secondWord.ToLower() != "exit");
            
        }
    }
}  
