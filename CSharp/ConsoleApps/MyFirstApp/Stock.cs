namespace MyFirstApp;

public class Stock : Asset
{
    public decimal Dividend { get; set; }

    public Stock(string name, decimal price, decimal dividend) : base(name, price)
    {
        this.Dividend = dividend;
    }
}