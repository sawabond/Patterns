namespace Decorator;

public class CoffeeDecoratorBase : ICoffee
{
    protected CoffeeDecoratorBase(ICoffee coffee)
    {
        Coffee = coffee;
    }

    protected ICoffee Coffee { get; }

    public virtual string Description => Coffee.Description;
    
    public virtual decimal Cost => Coffee.Cost;
    
    public override string ToString() => $"{Description} of price {Cost}";
}