namespace HttpRequestBuilder;

public class RequestDirector
{
    private readonly IRequestBuilder _builder;

    public RequestDirector(IRequestBuilder builder)
    {
        _builder = builder;
    }

    public HttpRequest BuildGet(string url)
    {
        return _builder
            .Reset()
            .SetUrl(url)
            .SetMethod("GET")
            .Build();
    }

    public HttpRequest BuildPost(string url, object data)
    {
        return _builder
            .Reset()
            .SetUrl(url)
            .SetMethod("POST")
            .SetBody(data)
            .Build();
    }
}
