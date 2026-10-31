namespace GameCharacterPrototype;

public class CharacterFactory
{
    private GameCharacter _prototype;

    public CharacterFactory(GameCharacter prototype)
    {
        _prototype = prototype;
    }

    public void SetCharacter(GameCharacter prototype)
    {
        _prototype = prototype;
    }

    public GameCharacter CloneCharacter()
    {
        return _prototype.Clone();
    }
}
