namespace FactoryMethod.Abstract;

/// <summary>
/// Concrete application - Paint. Concrete creator
/// </summary>
public sealed class PaintApplicationBase : ApplicationBase
{
    protected override DocumentBase CreateDocument()
    {
        return new PaintImageDocument();
    }
}