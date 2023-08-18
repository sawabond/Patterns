namespace Prototype;

public class CallingCode
{
    public static void Main()
    {
        var mainOfficeEmployeePrototype = new Employee
        {
            WorkAddress = new WorkAddress
            {
                Street = "Tsilinohradska 58",
                OfficeNumber = 228
            }
        };

        var bob = mainOfficeEmployeePrototype.Clone();
        bob.Name = "Bob";
        
        var alice = mainOfficeEmployeePrototype.Clone();
        alice.Name = "Alice";

        bob.WorkAddress.OfficeNumber = 444;
        alice.WorkAddress.OfficeNumber = 1234;

        Console.WriteLine(bob);
        Console.WriteLine(alice);
    }
}