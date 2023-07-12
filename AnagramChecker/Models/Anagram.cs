//Bussiness Logic

using System;
using System.Linq;
namespace AnagramChecker.Models
{
    public class Anagram 
    {
        public bool IsAnagram(string inputtedAnagramOne, string inputtedAnagramTwo)
        {
            //converting to character array 
            char[] anagramOneChars = inputtedAnagramOne.ToLower().ToCharArray();
            char[] anagramTwoChars = inputtedAnagramTwo.ToLower().ToCharArray();

            Array.Sort(anagramOneChars);
            Array.Sort(anagramTwoChars);

            return anagramOneChars.SequenceEqual(anagramTwoChars);
            
        }

    }

}

