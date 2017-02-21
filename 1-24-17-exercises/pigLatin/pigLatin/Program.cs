using System;
using static System.Console;

namespace pigLatin
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter any letter word:");
            string word = ReadLine();
            int wordLength = word.Length;
            int alteredLength = wordLength - 1;
            //string finalWord = word.Substring(0, alteredLength + 1);

            char chLetter = Char.ToLower(word.ToString(0, wordLength));
            bool isVowel(char chLetter){
                char[] letters = { 'a', 'e', 'i', 'o', 'u' };
            }
            if (isVowel(strWord[0]))
            {
                WriteLine("{0} translated into pig latin is {0}ay", word, word);
            }
            
            else
                {
                string finalWord = word.Substring(1, alteredLength) + word.Substring(0, 1);
                //string finalWord = word.Substring(1, 1) + word.Substring(2, 1) + word.Substring(0, 1);
                WriteLine("{0} translated into pig latin is {1}ay", word, finalWord);
            }
            }
    }
}
