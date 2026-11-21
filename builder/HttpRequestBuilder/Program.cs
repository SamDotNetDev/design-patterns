namespace HttpRequestBuilder;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("=== HTTP REQUEST BUILDER ===");
        Console.WriteLine();

        RequestBuilder builder = new RequestBuilder();
        RequestDirector director = new RequestDirector(builder);

        // 1. Builder orqali GET so'rov
        HttpRequest getRequest = builder
            .SetUrl("https://jsonplaceholder.typicode.com/posts/1")
            .SetMethod("GET")
            .SetHeader("Accept", "application/json")
            .Build();

        Console.WriteLine("1. GET so'rovi yuborilmoqda...");
        var getData = await getRequest.SendAsync();
        Console.WriteLine($"   Natija (title): {getData.GetProperty("title")}");

        // 2. Director orqali POST so'rov
        HttpRequest postRequest = director.BuildPost(
            "https://jsonplaceholder.typicode.com/posts",
            new { title = "Salom Dunyo", userId = 1 });

        Console.WriteLine();
        Console.WriteLine("2. POST so'rovi yuborilmoqda...");
        var postData = await postRequest.SendAsync();
        Console.WriteLine($"   Natija (yangi ID): {postData.GetProperty("id")}");

        // 3. URL'siz Build -> xatolik
        Console.WriteLine();
        try
        {
            builder.SetMethod("GET").Build();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("3. Xato: " + e.Message);
        }
    }
}
