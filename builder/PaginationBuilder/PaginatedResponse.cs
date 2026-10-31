namespace PaginationBuilder;

public class PaginatedResponse<T>
{
    public PageMeta Meta { get; }
    public List<T> Items { get; }

    private PaginatedResponse(List<T> items, PageMeta meta)
    {
        Items = items;
        Meta = meta;
    }

    // Murakkab javob obyektini bosqichma-bosqich yig'adi: avval meta, keyin javob
    public static PaginatedResponse<T> Build(List<T> items, PaginationParams parameters, int total)
    {
        PageMeta meta = PageMeta.FromTotal(parameters.Page, parameters.Size, total);
        return new PaginatedResponse<T>(items, meta);
    }
}
