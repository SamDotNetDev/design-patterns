namespace PaginationBuilder;

public class PageMeta
{
    public int Page { get; }
    public int Size { get; }
    public int Total { get; }
    public int Pages { get; }
    public bool HasNext { get; }
    public bool HasPrev { get; }

    private PageMeta(int page, int size, int total, int pages, bool hasNext, bool hasPrev)
    {
        Page = page;
        Size = size;
        Total = total;
        Pages = pages;
        HasNext = hasNext;
        HasPrev = hasPrev;
    }

    // Faqat page, size, total beriladi — qolganlari hisoblanadi
    public static PageMeta FromTotal(int page, int size, int total)
    {
        int pages = size > 0 ? (total + size - 1) / size : 0;
        return new PageMeta(page, size, total, pages, page < pages, page > 1);
    }

    public override string ToString()
    {
        return $"page={Page}, size={Size}, total={Total}, pages={Pages}, hasNext={HasNext}, hasPrev={HasPrev}";
    }
}
