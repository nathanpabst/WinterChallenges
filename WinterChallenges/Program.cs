using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace WinterChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\natha\source\repos\WinterChallenges\WinterChallenges\PizzaData\Pizza.json";

            //if (!File.Exists(path))
            //{
            //    string createText = "Welcome to Pizza Tracker" + Environment.NewLine;
            //    File.WriteAllText(path, createText);
            //}

            //string appendText = "Extra stuff" + Environment.NewLine;
            //File.AppendAllText(path, appendText);

            string readPizzaData = File.ReadAllText(path);
            var pizzas = JsonConvert.DeserializeObject<List<PizzaConfigs>>(readPizzaData);
            var combinations = new List<PizzaConfigs>();
            foreach (var pizza in pizzas)
            {
                if (combinations.Any(c => c.toppings.All(com => pizza.toppings.Contains(com))))
                {
                    var configIndex = combinations.FindIndex(c => c.toppings.All(com => pizza.toppings.Contains(com)));
                    combinations[configIndex].count++;
                }
                else
                {
                    pizza.count++;
                    combinations.Add(pizza);
                }
            }

            foreach (var combination in combinations.OrderBy(c => c.count).Reverse().Take(20))
            {
                foreach (var pizza in combinations)
                {
                    Console.WriteLine($"{String.Join(" and ", pizza.toppings)} ordered {pizza.count} times");
                }
            }





            Console.WriteLine(combinations);

            

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
