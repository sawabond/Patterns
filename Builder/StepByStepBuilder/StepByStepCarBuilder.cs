using System.Drawing;

namespace Builder.StepByStepBuilder;

public sealed class StepByStepCarBuilder 
    : IWithColorStage, IWithEngineVolumeStage, IWithModelStage, IBuildStage
{
    private Car _instance;
    
    public StepByStepCarBuilder()
    {
        _instance = new();
    }
    
    public IWithEngineVolumeStage WithColor(Color color)
    {
        _instance.Color = color;
        
        return this;
    }

    IWithModelStage IWithEngineVolumeStage.WithEngineVolume(double engineVolume)
    {
        _instance.EngineVolume = engineVolume;

        return this;
    }

    IBuildStage IWithModelStage.WithModel(string model)
    {
        _instance.Model = model;

        return this;
    }

    Car IBuildStage.Build()
    {
        return _instance;
    }
}