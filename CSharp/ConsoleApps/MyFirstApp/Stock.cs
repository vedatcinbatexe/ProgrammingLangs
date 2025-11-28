using MyFirstApp.Interfaces;

namespace MyFirstApp;

public class Stock : Asset, ILiquid
{
    public decimal Dividend { get; set; }

    public Stock(string name, decimal price, decimal dividend) : base(name, price)
    {
        this.Dividend = dividend;
    }
    
    // Override: We change the behavior
    public override void PrintInfo()
    {
        // Option 1: Completely replace it
        //Console.WriteLine($"Stock: {Name} - ${Price} (Div: {Dividend}%)");
        
        // Option 2: Ruın parent code FIRST, then add extra info
        base.PrintInfo();
        Console.WriteLine($"  -> Type: Stock, Dividend: {Dividend}%");
    }

    public override decimal CalculateTax()
    {
        // Stocks pay 15%
        return this.Price * 0.15m;
    }
    
    // Implementing the interface
    public void SellImmediate()
    {
        Console.WriteLine($"[Market Order] Sold {Name} instantly for ${Price}!");   
    }
}