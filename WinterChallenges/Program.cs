using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace WinterChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            //***************************************THE JOSEPHUS PROBLEM************************************//
            int numberOfPeeps = 11;
            int killingInterval = 3;
            int position = Josephus.LastPersonStanding(numberOfPeeps, killingInterval);
            Console.WriteLine($"The last man standing is {position}.");


            //****************************************PIZZA TRACKER * *****************************************//
            //string path = @"c:\Users\natha\source\repos\WinterChallenges\WinterChallenges\PizzaData\Pizza.json";

            //string readPizzaData = File.ReadAllText(path);
            //var pizzas = JsonConvert.DeserializeObject<List<PizzaConfigs>>(readPizzaData);
            //var combinations = new List<PizzaConfigs>();
            //******************spot check to ensure i'm counting the inverse order of a combination properly**********//
            //var pizzas = new List<PizzaConfigs> {
            //    new PizzaConfigs {
            //        toppings = new string[] {
            //            "pepperoni", "sausage"
            //        }
            //    },
            //    new PizzaConfigs {
            //        toppings = new string[] {
            //            "sausage", "pepperoni"
            //        }
            //    }
            //};
            //foreach (var pizza in pizzas)
            //{
            //    if (combinations.Any(c => c.toppings.All(topping => pizza.toppings.Contains(topping))))
            //    {
            //        var configIndex = combinations.FindIndex(c => c.toppings.All(topping => pizza.toppings.Contains(topping)));
            //        combinations[configIndex].count++;
            //    }
            //    else
            //    {
            //        pizza.count++;
            //        combinations.Add(pizza);

            //    }
            //}

            //foreach (var combination in combinations.OrderByDescending(c => c.count).Take(20))
            //{
            //    Console.WriteLine($"{String.Join(" and ", combination.toppings)} || {combination.count} orders");
            //}



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
