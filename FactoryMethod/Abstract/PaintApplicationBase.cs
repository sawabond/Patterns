namespace FactoryMethod.Abstract;

/// <summary>
/// Concrete application - Paint
/// </summary>
public sealed class PaintApplicationBase : ApplicationBase
{
    protected override DocumentBase CreateDocument()
    {
        return new PaintImageDocument();
    }
}