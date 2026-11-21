namespace FileSystemComposite;

public class Folder : IFileSystem
{
    private readonly string _name;
    private readonly List<IFileSystem> _children = new List<IFileSystem>();

    public Folder(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public Folder Add(IFileSystem item)
    {
        _children.Add(item);
        return this;
    }

    public Folder Remove(IFileSystem item)
    {
        _children.Remove(item);
        return this;
    }

    public void Show(string indent = "")
    {
        Console.WriteLine($"{indent}Folder: {_name}");
        foreach (IFileSystem child in _children)
        {
            child.Show(indent + "    ");
        }
    }
}
