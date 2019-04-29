using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator.");
            while(true)
            {
                Console.WriteLine("Enter a word and I'll translate it to pig latin");

                string str = Console.ReadLine();
                Console.WriteLine($"{str} in Pig Latin is {ToPigLatin(str)}");

                Console.WriteLine("Would you like to translate another? (Y/N)");
                string yesNo = Console.ReadLine().ToUpper();
                if(yesNo == "Y")
                {
                    continue;
                }
                else
                {
                    break;
                }

                break;
            }

        }

        public static string ToPigLatin(string str)
        {
            int indexOfVowel;
            string LowerCase = str.ToLower();
            string firstP = "";
            string secondP = "";


            if (IsVowel(LowerCase))
            {
                return LowerCase + "way";
            }
            else
            {
                foreach(char c in LowerCase)
                {
                    if(IsVowel(c))
                    {
                        indexOfVowel = LowerCase.IndexOf(c);
                        firstP = LowerCase.Substring(0, indexOfVowel);
                        secondP = LowerCase.Substring(indexOfVowel, LowerCase.Length-indexOfVowel);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                return secondP + firstP + "ay";
            }
        }

        public static bool IsVowel(char str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char first = str;
            foreach (char vowel in vowels)
            {
                if (str == vowel)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }

        public static bool IsVowel(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char first = str[0];
            foreach(char vowel in vowels)
            {
                if (str[0] == vowel)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
    }
}
