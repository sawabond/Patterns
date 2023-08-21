namespace Bridge.Solution;

public abstract class CarBase
{
    protected CarBase(CarColor color)
    {
        Color = color;
    }
    
    public CarColor Color { get; }
}