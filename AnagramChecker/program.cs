//UI Logic 

using System;
using AnagramChecker.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnagramChecker
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter a string");
            string anagramOne = Console.ReadLine();
            Console.WriteLine("Enter a second string ");
            string anagramTwo = Console.ReadLine();

            Anagram anagram = new Anagram();
            bool result = anagram.IsAnagram(anagramOne, anagramTwo);

            if (result)
            {
                Console.WriteLine("it's an anagram");
            }
            else
            {
                Console.WriteLine("Unfortunetly, not an anagram");

            }

        }


    }
}








