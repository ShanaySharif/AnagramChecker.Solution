//Bussiness Logic

using System;
using System.Linq;
namespace AnagramChecker.Models
{
    public class Vocab 
    {
        public bool IsAnagram(string inputtedWordOne, string inputtedWordTwo)
        {
            char[] wordOneChars = inputtedWordOne.ToLower().ToCharArray();
            char[] wordTwoChars = inputtedWordTwo.ToLower().ToCharArray();

            Array.Sort(wordOneChars);
            Array.Sort(wordTwoChars);

            return wordOneChars.SequenceEqual(wordTwoChars);
            
        }


        
    }

}

