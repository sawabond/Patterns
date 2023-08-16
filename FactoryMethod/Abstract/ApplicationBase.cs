namespace FactoryMethod.Abstract;

/// <summary>
/// Desktop application
/// </summary>
public abstract class ApplicationBase
{
    protected IEnumerable<DocumentBase> Documents { get; }

    /// <summary>
    /// At the base class level, we cannot know which type of documents the application
    /// will generate, so we define this as abstract method which will return
    /// DocumentBase class which can be down-casted to any DocumentBase inheritor
    /// </summary>
    /// <returns>A concrete document</returns>
    protected abstract DocumentBase CreateDocument();
}