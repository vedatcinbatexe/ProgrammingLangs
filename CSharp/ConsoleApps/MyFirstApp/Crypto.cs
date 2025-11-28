namespace MyFirstApp;

public class Crypto : Asset
{
    public string WalletAddress { get; set; }

    public Crypto(string name, decimal price, string wallet) : base(name, price)
    {
        this.WalletAddress = wallet;
    }
}