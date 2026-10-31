namespace PaginationBuilder;

public class Program
{
    public static void Main()
    {
        // "Bazadagi" 45 ta foydalanuvchi
        List<string> allUsers = Enumerable.Range(1, 45).Select(i => $"user{i}").ToList();

        foreach (int page in new[] { 1, 2, 3 })
        {
            PaginationParams parameters = new PaginationParams(page, 20);

            List<string> items = allUsers
                .Skip(parameters.Offset)
                .Take(parameters.Limit)
                .ToList();

            PaginatedResponse<string> response = PaginatedResponse<string>.Build(items, parameters, allUsers.Count);

            Console.WriteLine($"Meta:  {response.Meta}");
            Console.WriteLine($"Items: {string.Join(", ", response.Items)}");
            Console.WriteLine();
        }

        try
        {
            new PaginationParams(1, 500);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Xato: " + e.Message);
        }
    }
}
