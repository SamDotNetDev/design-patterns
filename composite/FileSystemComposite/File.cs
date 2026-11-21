namespace FileSystemComposite;

public class File : IFileSystem
{
    private readonly string _name;

    public File(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void Show(string indent = "")
    {
        Console.WriteLine($"{indent}File: {_name}");
    }
}
