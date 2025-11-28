using MyFirstApp.Interfaces;

namespace MyFirstApp;

public class Crypto : Asset, ILiquid
{
    public string WalletAddress { get; set; }

    public Crypto(string name, decimal price, string wallet) : base(name, price)
    {
        this.WalletAddress = wallet;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"   -> Type: Crypto, Wallet: {WalletAddress}");    
    }

    public override decimal CalculateTax()
    {
        // Crypto pais 5% tax
        return this.Price * 0.05m;
    }
    
    // IMPLEMENTING THE INTERFACE
    public void SellImmediate()
    {
        Console.WriteLine($"[Binance API] Sold {Name} to wallet {WalletAddress}.");
    }
}