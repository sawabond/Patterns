using System.Drawing;
using Builder.SimpleBuilder;
using Builder.StepByStepBuilder;

namespace Builder;

public class CallingCode
{
    public static void Main()
    {
        var builder = new SimpleCarBuilder();

        var car = builder.WithColor(Color.Aqua)
            .WithModel("Audi")
            .WithEngineVolume(3.5)
            .Build();
        
        Console.WriteLine(car);

        var car2 = new StepByStepCarBuilder()
            .WithColor(Color.Azure)
            .WithEngineVolume(3.5)
            .WithModel("Audi")
            .Build();
        
        Console.WriteLine(car2);
    }
}