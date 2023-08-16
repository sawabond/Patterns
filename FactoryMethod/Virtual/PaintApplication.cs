namespace FactoryMethod.Virtual;

/// <summary>
/// Concrete Paint application
/// </summary>
public sealed class PaintApplication : ApplicationBase
{

    /// <summary>
    /// By default <see cref="CreateDocument"/> will create simple general documents.
    /// We can override the creation because the method is virtual and now it returns PaintDocument
    /// </summary>
    /// <returns></returns>
    protected override Document CreateDocument()
    {
        // We still have access to base implementation
        var baseDocument = base.CreateDocument();
        
        return new PaintDocument();
    }
}