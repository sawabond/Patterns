using System.Runtime.CompilerServices;

namespace Singleton;

public class CallingCode
{
    public static void Main()
    {
        var instance = Singleton.Instance;
        var g1 = instance.Guid;

        var instance2 = Singleton.Instance;
        var g2 = instance2.Guid;

        Console.WriteLine(g1 == g2);
    }
}