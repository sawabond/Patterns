namespace Composite.BoxesExample;

public abstract class Product : ISellableItem
{
    protected Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    
    public string Name { get; }
    
    public decimal Price { get; }

    public decimal CalculatePrice() => Price;
}