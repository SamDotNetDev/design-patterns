namespace BridgeGames;

public class JavaDeveloper : IDeveloper
{
    public void WriteCode(string gameName)
    {
        Console.WriteLine($"Java dasturchisi {gameName} uchun Java tilida kod yozmoqda.");
    }
}
