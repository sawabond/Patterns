namespace Composite.BoxesExample;

public class CallingCode
{
    public static void Main()
    {
        var fork1 = new Fork("F1", 100);
        var fork2 = new Fork("F2", 200);

        var compositeBox = new CompositeBox();
        compositeBox.Add(fork1);
        compositeBox.Add(fork2);

        var topLevelCompositeBox = new CompositeBox();
        topLevelCompositeBox.Add(compositeBox);
        topLevelCompositeBox.Add(new Laptop("Macbook", 234000));

        // We do not care either a simple product or a composite product
        // We use a single ISellableItem interface
        var forkPrice = fork1.CalculatePrice();
        var price = topLevelCompositeBox.CalculatePrice();
    }
}