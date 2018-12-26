using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WinterChallenges
{
    static class Palindrome
    {
        //Write a method that determines whether a phrase represents a palindrome.
        //ignore the case, spaces and punctuation from the input.
        //use system.linq 

        public static string TestForPalindrome(string input)
        {
            var prepInput = String.Join("", input.ToList()
                .Where(c => !char.IsPunctuation(c)))
                .Replace(" ", "")
                .ToLower();
            Console.WriteLine(prepInput);

            return "yatzee";
        }
    }
}
