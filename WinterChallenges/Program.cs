using System;
using System.Linq;

namespace WinterChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Palindrome Checker.");
            Console.WriteLine("Enter a word or phrase to begin.");
            Console.ReadLine();
        }

        //Write a method that determines whether a phrase represents a palindrome.
        //ignore the case, spaces and punctuation from the input.
        //use system.linq 
         
        private static void TestForPalindrome(string input)
        {
            //var prepInput = String.Join("", input.ToList().Where(char => !char.IsPunctuation(char))).Replace(" ", "").ToLower();
        }
    }
}
