using System;
using System.Collections.Generic;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator!");

            // Ask for the price of the item
            Console.Write("Enter the price of the item: ");
            decimal price = decimal.Parse(Console.ReadLine());

            // Ask for the money handed by the customer
            Console.Write("Enter the amount of money handed by the customer: ");
            decimal moneyGiven = decimal.Parse(Console.ReadLine());

            // Calculate the change
            decimal change = moneyGiven - price;

            if (change < 0)
            {
                Console.WriteLine("Insufficient money provided. Please try again.");
            }
            else
            {
                // Round the change to the nearest 5 cents
                decimal roundedChange = Math.Round(change / 0.05m) * 0.05m;

                // Calculate the denominations of paper money and coins
                Dictionary<string, int> denominations = CalculateDenominations(roundedChange);

                // Display the change breakdown
                Console.WriteLine("Change breakdown:");
                foreach (var denomination in denominations)
                {
                    Console.WriteLine($"{denomination.Value} {denomination.Key}");
                }
            }

            Console.ReadLine();
        }

        static Dictionary<string, int> CalculateDenominations(decimal change)
        {
            Dictionary<string, int> denominations = new Dictionary<string, int>();

            decimal[] availableDenominations = { 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.25m, 0.10m, 0.05m };
            string[] denominationNames = { "100 Dollar Bill", "50 Dollar Bill", "20 Dollar Bill", "10 Dollar Bill", "5 Dollar Bill", "2 Dollar Coin", "1 Dollar Coin", "25 Cent Coin", "10 Cent Coin", "5 Cent Coin" };

            foreach (var denomination in availableDenominations)
            {
                if (change >= denomination)
                {
                    int count = (int)(change / denomination);
                    denominations.Add(denominationNames[Array.IndexOf(availableDenominations, denomination)], count);
                    change -= denomination * count;
                }
            }

            return denominations;
        }
    }
}
