namespace Singleton;

public sealed class Singleton
{
    private static readonly object _lock = new();
    
    private static Singleton _instance;

    private Singleton() => Guid = Guid.NewGuid();
    
    public Guid Guid { get; }

    public static Singleton Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    _instance ??= new();
                }
            }
            
            return _instance;
        }
    }
}