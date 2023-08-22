namespace Decorator;

public sealed class CoffeeWithSugar : CoffeeDecoratorBase
{
    public CoffeeWithSugar(ICoffee coffee) : base(coffee)
    {
    }

    public override string Description => Coffee.Description + " with sugar";
    
    public override decimal Cost => Coffee.Cost + 20;
}