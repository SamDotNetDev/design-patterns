namespace GameCharacterPrototype;

public class GameCharacter : ICopyable<GameCharacter>
{
    // C# property = getter + setter
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public string Weapon { get; set; }

    public GameCharacter(int id, string name, int level, string weapon)
    {
        Id = id;
        Name = name;
        Level = level;
        Weapon = weapon;
    }

    public GameCharacter Clone()
    {
        return new GameCharacter(Id, Name, Level, Weapon);
    }

    public override string ToString()
    {
        return $"GameCharacter {{ Id = {Id}, Name = {Name}, Level = {Level}, Weapon = {Weapon} }}";
    }
}
