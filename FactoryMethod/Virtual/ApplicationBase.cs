namespace FactoryMethod.Virtual;

public abstract class ApplicationBase
{
    protected IEnumerable<Document> Documents { get; }

    protected virtual Document CreateDocument()
    {
        return new Document();
    }
}