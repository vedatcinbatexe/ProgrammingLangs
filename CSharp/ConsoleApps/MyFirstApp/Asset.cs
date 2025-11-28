using System;

namespace MyFirstApp {}

/* public class Asset
{
    // Properties
    public string Name;
    public decimal Price;
    public string Symbol;

    // Method (Action)
    // This asset knows how to introduce itself
    public void PrintInfo()
    {
        Console.WriteLine($"Asset: {Name} ({Symbol})");
        Console.WriteLine($"Current Price: ${Price}");
        Console.WriteLine("-------------------------");
    }
} */

public class Asset
{
    public string Name;
    public decimal _price;

    // Constructor method here with the same name as class
    public Asset(string name, decimal price)
    {
        // this.Name refers to the Class variable above
        // name refers to the input parameter
        this.Name = name;
        this.Price = price;
    }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
            {
                _price = value;
            }
            else
            {
                Console.WriteLine("Error: Price cannot be negative!");
            }
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Asset: {Name} - ${Price}");
    }
}