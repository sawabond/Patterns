using Newtonsoft.Json;

namespace Prototype;

public interface IPrototype<T>
{
    T Clone();
}