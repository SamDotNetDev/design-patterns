namespace DocumentPrototype;

public class DocumentFactory
{
    private Document _prototype;

    public DocumentFactory(Document prototype)
    {
        _prototype = prototype;
    }

    public void SetDocument(Document prototype)
    {
        _prototype = prototype;
    }

    public Document CloneDocument()
    {
        return _prototype.Clone();
    }
}
