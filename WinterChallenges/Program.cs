using System;
using System.Linq;

namespace WinterChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Palindrome Checker.");
            while (true)
            {
                Console.Write("Enter a word or phrase here: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string output = Palindrome.TestForPalindrome(input);
            }

            Console.Read();
        }

        
    }
        
}
