using System;

namespace MyFirstApp {}

class Program
{
    // Method: The entry point. 'Main' is C# always starts
    static void Main(string[] args)
    {
        // This is comment
        /* Console.WriteLine("System Booting...");
        Console.WriteLine("Welcome to the C# Architecture"); */

        // Variables and Data Types
        /* string assetName = "Gold (Gram)";

        decimal pricePerGram = 2950.50m;

        int gramsOwned = 15;

        decimal totalValue = pricePerGram * gramsOwned;

        bool isProfitable = true;

        Console.WriteLine("Portfolio Report:");
        Console.WriteLine("Asset: " + assetName);
        Console.WriteLine("Price: " + pricePerGram);
        Console.WriteLine("Owned: " + gramsOwned);
        Console.WriteLine("Total Value: " + totalValue);
        Console.WriteLine("In Profit: " + isProfitable); */

        // CONTROL FLOW
        // Console.WriteLine("--- GOLD TRADING BOT ACTIVATED ---");
        // Console.WriteLine("Type 'exit' to stop the bot.");


        // Runs forever unless we break it
        /*
        while(true)
        {
            Console.WriteLine("Enter current Gold Price:");
            string input = Console.ReadLine();

            if(input == "exit")
            {
                Console.WriteLine("Bot shutting down...");
                break; // Kills the loop immediately
            }

            decimal price = decimal.Parse(input);

            if(price < 2900)
            {
                Console.WriteLine(">>> SIGNAL: BUY! Cheap Gold");
            }else if(price > 3100)
            {
                Console.WriteLine(">>> SIGNAL: SELL! Take Profit");
            }else
            {
                Console.WriteLine(">>> SIGNAL: HOLD. Market is flat");
            }

            Console.WriteLine("-------------------------------");
            
        }
        */

        Console.WriteLine("--- METHOD-POWERED TRADING BOT ---");
        
        while(true) {
            decimal currentPrice = GetPriceFromUser();

            MakeDecision(currentPrice);
        }

        static decimal GetPriceFromUser()
        {
            Console.Write("Enter current Gold Price: ");
            string input = Console.ReadLine();   

            decimal price;
            decimal.TryParse(input, out price); 
            
            return price;
        
        }

        static void MakeDecision(decimal price)
        {
            if (price == 0)
            {
                Console.WriteLine("Error: Invalid price entered.");
                return;
            }

            if (price < 2900)
            {
                Console.WriteLine(">>> SIGNAL: BUY");
            }
            else if (price > 3100)
            {
                Console.WriteLine(">>> SIGNAL: SELL");
            }
            else
            {
                Console.WriteLine(">>> SIGNAL: HOLD");
            }
            
            Console.WriteLine("-----------------------------");
        }

    }
}