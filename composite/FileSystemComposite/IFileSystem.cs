namespace FileSystemComposite;

public interface IFileSystem
{
    string GetName();
    void Show(string indent = "");
}
