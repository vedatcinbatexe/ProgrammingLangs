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
    public string Name { get; set; }
    public decimal Price { get; set; }

    // Constructor method here with the same name as class
    public Asset(string name, decimal price)
    {
        // this.Name refers to the Class variable above
        // name refers to the input parameter
        this.Name = name;
        this.Price = price;
    }

    // Add 'virtual' here
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Asset: {Name} - ${Price}");
    }
}