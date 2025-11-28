using System;
using MyFirstApp;

namespace MyFirstApp {}
 
 class Program
 {
     // Method: The entry point. 'Main' is C# always starts
     static void Main(string[] args)
     {
         // Create a STOCK
         //Stock apple = new Stock("Apple", 230.0m, 1.5m);
         
         // Create a CRYPTO
         //Crypto bitcoin = new Crypto("Bitcoin", 95000.00m, "0x123abc...");
         
         //Console.Write("--- MARKET DATA --- \n");

         //apple.PrintInfo();
         //bitcoin.PrintInfo();
         
         //Console.WriteLine($"Apple Dividend: ${apple.Dividend}");
         //Console.WriteLine($"BTC Wallet: ${bitcoin.WalletAddress}");

         List<Asset> myPortfolio = new List<Asset>();
         
         // Add different types of children to the SAME list
         myPortfolio.Add(new Stock("Apple", 230.00m, 1.5m));
         myPortfolio.Add(new Stock("Tesla", 300.00m, 2.5m));
         
         myPortfolio.Add(new Crypto("Bitcoin", 95000.00m, "0x123abc.."));
         myPortfolio.Add(new Asset("Unknown Land", 50000m)); // A Generic Asset
         
         // Loop
         foreach (Asset item in myPortfolio)
         {
             item.PrintInfo();
             Console.WriteLine("------------");
         }

     }
 }