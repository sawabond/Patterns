using System.Drawing;

namespace Builder.SimpleBuilder;

public sealed class SimpleCarBuilder
{
    private Car _instance;

    public SimpleCarBuilder()
    {
        _instance = new();
    }
    
    public SimpleCarBuilder WithColor(Color color)
    {
        _instance.Color = color;

        return this;
    }

    public SimpleCarBuilder WithModel(string model)
    {
        _instance.Model = model;

        return this;
    }

    public SimpleCarBuilder WithEngineVolume(double engineVolume)
    {
        _instance.EngineVolume = engineVolume;

        return this;
    }

    public Car Build()
    {
        return _instance;
    }
}