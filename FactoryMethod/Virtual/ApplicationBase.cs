namespace FactoryMethod.Virtual;

public abstract class ApplicationBase
{
    protected IEnumerable<Document> Documents { get; }

    /// <summary>
    /// Factory method
    /// </summary>
    /// <returns></returns>
    protected virtual Document CreateDocument()
    {
        return new Document();
    }
}