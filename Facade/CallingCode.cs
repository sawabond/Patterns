namespace Facade;

public class CallingCode
{
    public static void Main()
    {
        var facade = new HomeTheaterFacade();
        facade.WatchMovie("God Father 1");
        facade.EndMovie();
    }
}