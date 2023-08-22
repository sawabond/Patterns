namespace Decorator;

public sealed class Coffee : ICoffee
{
    public string Description => "Default coffee";

    public decimal Cost => 100;

    public override string ToString() => $"{Description} of price {Cost}";
}