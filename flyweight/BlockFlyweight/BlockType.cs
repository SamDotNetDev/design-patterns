namespace BlockFlyweight;

// Flyweight: bir xil turdagi bloklar uchun umumiy (intrinsic) holat
public class BlockType
{
    public BlockType(string name, string texture, string color)
    {
        Name = name;
        Texture = texture;
        Color = color;
    }

    public string Name { get; }
    public string Texture { get; }
    public string Color { get; }

    public override string ToString()
    {
        return Name;
    }
}
