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
            string anagaramOne = Console.ReadLine();
            Console.WriteLine("Enter a second string ");
            string anagramTwo = Console.ReadLine();

            bool result = IsAnagram(anagaramOne, anagramTwo);

            if (result)
            {
                Console.WriteLine("it's an anagram");
            }
            else
            {
                Console.WriteLine("Unfortunetly, not an anagram");

            }
            


            }

        private static bool IsAnagram(string anagaramOne, string anagramTwo)
        {
            throw new NotImplementedException();
        }
    }
    }







    //        Console.WriteLine("Enter first string");
    //        string (inputtedAnagaramOne, inputtedAnagramTwo)


    //         Console.WriteLine("Enter second string");
    //         inputtedAnagramOne = Console.ReadLine();

    //         inputtedAnagramTwo = Console.ReadLine();
    //         Anagaram Anagram = new Anagram();

    //         if (Anagram.IsAnagram(inputtedAnagaramOne, inputtedAnagaramTwo) == true)
    //         {
    //             Console.Write("Both strings are anagrams ");
    //         }
    //         else
    //             Console.Write("Sorry not an Anagram");



    //     }
    //     Console.ReadLine();
    // }






// }

// private static bool IsAnagram(string anagaramOne, string anagramTwo)
// {
//     throw new NotImplementedException();
// }
//     }
// }
