using System;
using System.IO;


namespace WinterChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\natha\source\repos\WinterChallenges\WinterChallenges\PizzaData\Pizza.json";
            string[] getPizzaData = File.ReadAllLines(path);
            foreach (string s in getPizzaData)
            {
                Console.WriteLine(s.ToString());

            }

            //*************PALINDROMES****************************//
            //Console.WriteLine("Welcome to the Palindrome Checker.");

            //***************while (true) loop allows the user to continue using the program
            //while (true)
            //{
            //    Console.Write("Enter a word or phrase here: ");
            //    string input = Console.ReadLine();

            //*************the loop will stop when the user input is null or whitespace
            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }

            //    string output = Palindrome.TestForPalindrome(input);
            //}

            Console.Read();
        }

        
    }
        
}
