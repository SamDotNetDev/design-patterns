namespace BlockFlyweight;

public class Program
{
    public static void Main()
    {
        World world = new World();

        world.AddBlock(0, 0, 0, "Grass");
        world.AddBlock(1, 0, 0, "Grass");
        world.AddBlock(2, 0, 0, "Stone");
        world.AddBlock(3, 0, 0, "Grass");
        world.AddBlock(4, 0, 0, "Dirt");

        world.Render();

        var blocks = world.Blocks;
        Console.WriteLine();
        Console.WriteLine($"Grass == Grass: {ReferenceEquals(blocks[0].Type, blocks[1].Type)}");
        Console.WriteLine($"Grass == Stone: {ReferenceEquals(blocks[0].Type, blocks[2].Type)}");
    }
}
