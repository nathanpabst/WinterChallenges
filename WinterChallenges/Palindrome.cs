using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WinterChallenges
{
    class Palindrome
    {
        //Write a method that determines whether a phrase represents a palindrome.
        //use system.linq to access .Join, .ToList, .Reverse methods

        public static string TestForPalindrome(string input)
        {
            //ignore spaces
            var prepInput = String.Join("", input.ToList()
                //check for and ignore any punctuation
                .Where(c => !char.IsPunctuation(c)))
                .Replace(" ", "")
                //convert the word or phrase to lower case
                .ToLower();

            if (prepInput.Equals(String.Join("", prepInput.Reverse())))
            {
                Console.WriteLine($"Yes! '{ input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"Nope. '{ input }' is not a palindrome.");
            }
            return "yatzee";
        }
    }
}
