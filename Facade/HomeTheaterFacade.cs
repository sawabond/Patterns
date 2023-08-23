public sealed class HomeTheaterFacade
{
    private DvdPlayer dvdPlayer = new();
    private Projector projector = new();
    private AudioSystem audioSystem = new();

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        dvdPlayer.TurnOn();
        dvdPlayer.PlayMovie(movie);
        projector.TurnOn();
        projector.SetInput("DVD");
        audioSystem.TurnOn();
        audioSystem.SetVolume(10);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the home theater...");
        dvdPlayer.TurnOff();
        projector.TurnOff();
        audioSystem.TurnOff();
    }
}
