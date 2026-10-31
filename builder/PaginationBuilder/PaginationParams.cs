namespace PaginationBuilder;

public class PaginationParams
{
    public int Page { get; }
    public int Size { get; }

    public PaginationParams(int page = 1, int size = 20)
    {
        if (page < 1)
            throw new ArgumentOutOfRangeException(nameof(page), "page >= 1 bo'lishi kerak");
        if (size < 1 || size > 200)
            throw new ArgumentOutOfRangeException(nameof(size), "size 1..200 oralig'ida bo'lishi kerak");

        Page = page;
        Size = size;
    }

    public int Offset => (Page - 1) * Size;

    public int Limit => Size;
}
