namespace Composite.BoxesExample;

public class CompositeBox : ISellableItem
{
    private readonly List<ISellableItem> _items = new();

    public void Add(ISellableItem item) => _items.Add(item);

    public void Remove(ISellableItem item) => _items.Remove(item);

    public decimal CalculatePrice() => _items.Sum(x => x.CalculatePrice());
}