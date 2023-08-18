using Newtonsoft.Json;

namespace Prototype;

public sealed class Employee : IPrototype<Employee>
{
    public string Name { get; set; }
    
    public WorkAddress WorkAddress { get; set; }
    
    public Employee Clone() => JsonConvert.DeserializeObject<Employee>(JsonConvert.SerializeObject(this));

    public override string ToString()
    {
        return $"{Name}, {WorkAddress}";
    }
}