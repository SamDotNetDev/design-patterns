namespace BlockFlyweight;

// Har bir blokning o'ziga xos (extrinsic) holati: koordinatalar
public class Block
{
    public Block(int x, int y, int z, BlockType type)
    {
        X = x;
        Y = y;
        Z = z;
        Type = type;
    }

    public int X { get; }
    public int Y { get; }
    public int Z { get; }
    public BlockType Type { get; }

    public string Render()
    {
        return $"[{X},{Y},{Z}] {Type}";
    }
}
