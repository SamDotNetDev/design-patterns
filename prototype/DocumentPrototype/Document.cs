namespace DocumentPrototype;

public class Document : ICopyable<Document>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public List<string> Tags { get; set; }

    public Document(int id, string title, string content, string author, List<string> tags)
    {
        Id = id;
        Title = title;
        Content = content;
        Author = author;
        Tags = tags;
    }

    // Copy constructor — Deep Copy: tags uchun yangi ro'yxat yaratiladi
    public Document(Document source)
    {
        Id = source.Id;
        Title = source.Title;
        Content = source.Content;
        Author = source.Author;
        Tags = new List<string>(source.Tags);
    }

    public Document Clone()
    {
        return new Document(this);
    }

    // Faqat taqqoslash uchun: Shallow Copy — Tags ro'yxati umumiy bo'lib qoladi
    public Document ShallowClone()
    {
        return (Document)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Document {{ Id = {Id}, Title = {Title}, Content = {Content}, Author = {Author}, Tags = [{string.Join(", ", Tags)}] }}";
    }
}
