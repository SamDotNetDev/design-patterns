namespace BridgeGames;

// Abstraction: Developer obyektini saqlaydi (ko'prik shu yerda)
public abstract class Game
{
    protected readonly IDeveloper Developer;

    protected Game(IDeveloper developer)
    {
        Developer = developer;
    }

    public abstract void Create();
}
