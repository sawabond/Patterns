namespace Decorator;

public class CallingCode
{
    public static void Main()
    {
        ICoffee simpleCoffee = new Coffee();
        ICoffee coffeeWithSugar = new CoffeeWithSugar(simpleCoffee);
        ICoffee coffeeWithSugarAndMilk = new CoffeeWithMilk(coffeeWithSugar);

        Console.WriteLine(coffeeWithSugarAndMilk);
    }
}