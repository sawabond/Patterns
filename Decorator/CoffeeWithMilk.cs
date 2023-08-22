namespace Decorator;

public sealed class CoffeeWithMilk : CoffeeDecoratorBase
{
    public CoffeeWithMilk(ICoffee coffee) : base(coffee)
    {
    }
    public override string Description => Coffee.Description + " with milk";
    public override decimal Cost => Coffee.Cost + 25;
}