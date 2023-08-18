using System.Drawing;

namespace Builder.StepByStepBuilder;

public interface IWithColorStage
{
    IWithEngineVolumeStage WithColor(Color color);
}