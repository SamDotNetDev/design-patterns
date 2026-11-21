namespace BlockFlyweight;

public class World
{
    private readonly List<Block> _blocks = new List<Block>();

    public IReadOnlyList<Block> Blocks => _blocks;

    public void AddBlock(int x, int y, int z, string typeName)
    {
        _blocks.Add(new Block(x, y, z, BlockFactory.GetBlockType(typeName)));
    }

    public void Render()
    {
        foreach (Block block in _blocks)
        {
            Console.WriteLine(block.Render());
        }
        Console.WriteLine();
        Console.WriteLine($"Bloklar: {_blocks.Count} | Noyob turlar: {BlockFactory.UniqueCount}");
    }
}
