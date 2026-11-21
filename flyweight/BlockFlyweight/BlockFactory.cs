namespace BlockFlyweight;

public static class BlockFactory
{
    private static readonly Dictionary<string, (string Texture, string Color)> BlockData = new()
    {
        ["Grass"] = ("grass_block.png", "Yashil"),
        ["Stone"] = ("stone_block.png", "Kulrang"),
        ["Dirt"] = ("dirt_block.png", "Jigarrang"),
        ["Water"] = ("water_block.png", "Ko'k"),
    };

    private static readonly Dictionary<string, BlockType> BlockTypes = new Dictionary<string, BlockType>();

    public static BlockType GetBlockType(string name)
    {
        if (!BlockTypes.TryGetValue(name, out BlockType? blockType))
        {
            if (!BlockData.TryGetValue(name, out var data))
            {
                throw new ArgumentException($"Noma'lum blok turi: {name}");
            }
            blockType = new BlockType(name, data.Texture, data.Color);
            BlockTypes[name] = blockType;
        }
        return blockType;
    }

    public static int UniqueCount => BlockTypes.Count;
}
