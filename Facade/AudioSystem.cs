public sealed class AudioSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Audio System is on");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine("Setting volume to: " + volume);
    }

    public void TurnOff()
    {
        Console.WriteLine("Audio System is off");
    }
}