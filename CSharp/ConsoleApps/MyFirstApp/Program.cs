using System;
using MyFirstApp;

namespace MyFirstApp {}
 
 class Program
 {
     // Method: The entry point. 'Main' is C# always starts
     static void Main(string[] args)
     {
         // Create a STOCK
         Stock apple = new Stock("Apple", 230.0m, 1.5m);
         
         // Create a CRYPTO
         Crypto bitcoin = new Crypto("Bitcoin", 95000.00m, "0x123abc...");
         
         Console.Write("--- MARKET DATA ---");

         apple.PrintInfo();
         bitcoin.PrintInfo();
         
         Console.WriteLine($"Apple Dividend: ${apple.Dividend}");
         Console.WriteLine($"BTC Wallet: ${bitcoin.WalletAddress}");
     }
 }