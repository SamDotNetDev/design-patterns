namespace GameCharacterPrototype;

public class GameRunner
{
    public static void Main()
    {
        GameCharacter original = new GameCharacter(1, "Warrior", 10, "Sword");

        CharacterFactory factory = new CharacterFactory(original);

        GameCharacter clone1 = factory.CloneCharacter();
        GameCharacter clone2 = factory.CloneCharacter();

        clone1.Id = 2;
        clone1.Name = "Archer";
        clone1.Level = 15;
        clone1.Weapon = "Bow";

        clone2.Id = 3;
        clone2.Name = "Mage";
        clone2.Level = 20;
        clone2.Weapon = "Staff";

        Console.WriteLine("Original: " + original);
        Console.WriteLine("Clone 1:  " + clone1);
        Console.WriteLine("Clone 2:  " + clone2);
        Console.WriteLine();

        bool unchanged = original.Name == "Warrior" && original.Level == 10 && original.Weapon == "Sword";
        Console.WriteLine($"Original o'zgarmadimi: {unchanged}");

        Console.WriteLine($"original == clone1: {ReferenceEquals(original, clone1)}");
        Console.WriteLine($"original == clone2: {ReferenceEquals(original, clone2)}");
        Console.WriteLine($"clone1 == clone2:   {ReferenceEquals(clone1, clone2)}");
    }
}
