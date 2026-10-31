namespace BridgeGames;

public class RacingGame : Game
{
    public RacingGame(IDeveloper developer) : base(developer) { }

    public override void Create()
    {
        Console.WriteLine("Poyga o'yini (RacingGame) yaratilmoqda...");
        Developer.WriteCode("RacingGame");
    }
}
