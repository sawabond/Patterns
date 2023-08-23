public sealed class DvdPlayer
{
    public void TurnOn()
    {
        Console.WriteLine("DVD Player is on");
    }

    public void PlayMovie(string movie)
    {
        Console.WriteLine("Playing movie: " + movie);
    }

    public void TurnOff()
    {
        Console.WriteLine("DVD Player is off");
    }
}