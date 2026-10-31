namespace BridgeGames;

public class CppDeveloper : IDeveloper
{
    public void WriteCode(string gameName)
    {
        Console.WriteLine($"C++ dasturchisi {gameName} uchun C++ tilida kod yozmoqda.");
    }
}
