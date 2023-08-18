namespace Prototype;

public sealed class WorkAddress
{
    public string Street { get; set; }

    public int OfficeNumber { get; set; }

    public override string ToString()
    {
        return $"{Street}, {OfficeNumber}";
    }
}