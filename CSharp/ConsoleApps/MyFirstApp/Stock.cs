namespace MyFirstApp;

public class Stock : Asset
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
}