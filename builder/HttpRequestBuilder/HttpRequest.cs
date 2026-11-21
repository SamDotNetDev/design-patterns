using System.Text;
using System.Text.Json;

namespace HttpRequestBuilder;

public class HttpRequest
{
    private static readonly HttpClient _client = new HttpClient();

    public string Url { get; set; } = "";
    public string Method { get; set; } = "GET";
    public Dictionary<string, string> Headers { get; } = new Dictionary<string, string>();
    public object? Body { get; set; }

    public async Task<JsonElement> SendAsync()
    {
        using HttpRequestMessage message = new HttpRequestMessage(new HttpMethod(Method), Url);

        foreach (var header in Headers)
        {
            if (header.Key != "Content-Type")
            {
                message.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }
        }

        if (Body != null)
        {
            message.Content = new StringContent(JsonSerializer.Serialize(Body), Encoding.UTF8, "application/json");
        }

        using HttpResponseMessage response = await _client.SendAsync(message);
        string json = await response.Content.ReadAsStringAsync();
        return JsonDocument.Parse(json).RootElement.Clone();
    }
}
