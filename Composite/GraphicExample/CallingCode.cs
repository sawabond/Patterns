namespace Composite.GraphicExample;

public class CallingCode
{
    public static void Main()
    {
        var drawing = new GrapicObject { Name = "My drawing" };
        drawing.Children.Add(new Square{Color = "Red"});
        drawing.Children.Add(new Circle{Color = "Blue"});

        var group = new GrapicObject();
        group.Children.Add((new Circle {Color = "Yellow"}));
        group.Children.Add(new Square{Color = "Green"});

        drawing.Children.Add(group);

        Console.WriteLine(drawing.ToString());
    }
}