using System;

namespace MyFirstApp {}

class Program
{
    // Method: The entry point. 'Main' is C# always starts
    static void Main(string[] args)
    {
        Asset gold = new Asset("Gold", "XAUUSD", 2650.50m);
        Asset bitcoin = new Asset("Bitcoin", "BTCUSD", 95000.00m);
        Asset apple = new Asset("Apple Inc.", "AAPL", 230.00m);

        Console.WriteLine("--- PORTFOLIO ---");
        gold.PrintInfo();
        bitcoin.PrintInfo();
        apple.PrintInfo();
    }
}