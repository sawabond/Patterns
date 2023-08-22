using System.Text;

namespace Composite.GraphicExample;

public class GrapicObject
{
    private readonly Lazy<List<GrapicObject>> _children = new();
    
    public List<GrapicObject> Children => _children.Value;
    
    public string Color { get; set; }

    public virtual string Name { get; set; } = "Group";

    private void Print(StringBuilder builder, int depth)
    {
        builder.Append(new string('*', depth))
            .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : Color)
            .AppendLine(Name);

        depth++;
        
        foreach (var child in Children)
        {
            child.Print(builder, depth);
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        Print(sb, 0);
        return sb.ToString();
    }
}