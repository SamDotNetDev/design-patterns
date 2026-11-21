namespace FileSystemComposite;

public class Program
{
    public static void Main()
    {
        Folder computer = new Folder("Computer");
        Folder documents = new Folder("Documents");
        Folder photos = new Folder("Photos");
        Folder university = new Folder("University");

        documents.Add(new File("resume.pdf")).Add(new File("homework.docx"));
        photos.Add(new File("photo1.jpg")).Add(new File("photo2.jpg"));
        computer.Add(documents).Add(photos).Add(new File("music.mp3"));

        university.Add(new File("Java.java")).Add(new File("Python.py"));
        documents.Add(university);

        File temp = new File("temp.txt");
        computer.Add(temp);
        computer.Remove(temp);

        computer.Show();
    }
}
